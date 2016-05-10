using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;

using Suplex.Data;
using Suplex.Forms;
using Suplex.Security;
using Suplex.Security.Standard;

namespace Suplex.WinForms
{
	/// <summary>
	/// Provides extended validation properties and auto-validation.
	/// </summary>
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(DomainUpDown))]
	[EventBindings( EventBindingsAttribute.BaseEvents.WinForms, ControlEvents.SelectedIndexChanged | ControlEvents.TextChanged )]
	public class sDomainUpDown : System.Windows.Forms.DomainUpDown, IValidationControl, ISecureControl
	{
		private string _uniqueName = null;
		private DataAccessLayer _dal = new DataAccessLayer();
		private SecurityAccessor _sa = null;
		private SecurityResultCollection _sr = null;
		private ValidationAccessor _va = null;


		private int _lastSelectedIndex = -1;
		private string _lastText = "";


		#region Events
		public event EventHandler SelectedItemChangedEx;
		//see below for SelectedIndexChangedEx implementation
		#endregion


		public sDomainUpDown() : base()
		{
			_sa = new SecurityAccessor( this, AceType.UI );
			_sr = _sa.Descriptor.SecurityResults;
			_va = new ValidationAccessor( this, TypeCode.String );
		}

		protected override void InitLayout()
		{
			_sa.EnsureDefaultState();

			base.InitLayout();
		}


		[ParenthesizePropertyName( true ), Category( "Suplex" ),
		DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public string UniqueName
		{
			get
			{
				return string.IsNullOrEmpty( _uniqueName ) ? base.Name : _uniqueName;
			}
			set
			{
				_uniqueName = value;
			}
		}

		[Browsable( false ),
		DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public Suplex.Data.DataAccessLayer DataAccessLayer
		{
			get { return _dal; }
			set { _dal = value; }
		}


		#region Validation Implementation
		[TypeConverter( typeof( ExpandableObjectConverter ) ), Category( "Suplex" ),
		DesignerSerializationVisibility( DesignerSerializationVisibility.Content ),
		Description( "Provides access to Validation management properties and tools." )]
		public IValidationAccessor Validation
		{
			get { return _va; }
		}

		public virtual ValidationResult ProcessValidate(bool processFillMaps)
		{
			ValidationResult vr = new ValidationResult( this.UniqueName );
			if( this.Enabled )
			{
				vr = _va.ProcessEvent( this.SelectedItem.ToString(), ControlEvents.Validating, processFillMaps );
			}
			return vr;
		}

		protected override void OnValidating(CancelEventArgs e)
		{
			e.Cancel = !this.ProcessValidate( true ).Success;

			base.OnValidating( e );
		}

		protected override void OnEnter(EventArgs e)
		{
			_va.ProcessEvent( this.SelectedItem.ToString(), ControlEvents.Enter, true );
			base.OnEnter( e );
		}

		protected override void OnLeave(EventArgs e)
		{
			_va.ProcessEvent( this.SelectedItem.ToString(), ControlEvents.Leave, true );
			base.OnLeave( e );
		}

		protected override void OnEnabledChanged(EventArgs e)
		{
			if( _sr[AceType.UI, UIRight.Enabled].AccessAllowed )
			{
				_va.ProcessEvent( this.Text, ControlEvents.EnabledChanged, true );
				//_sa.AuditAccess( this, AceType.UI, UIRight.Enabled, _auditEventHandler );

				base.OnEnabledChanged( e );
			}
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			if( _sr[AceType.UI, UIRight.Visible].AccessAllowed )
			{
				_va.ProcessEvent( this.Text, ControlEvents.VisibleChanged, true );
				//SecureControlUtils.AuditAccess( this, AceType.UI, UIRight.Visible, _auditEventHandler );

				base.OnVisibleChanged( e );
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			_sa.AuditAction( AuditType.ControlDetail, null, "TextChanged.", false );

			if( _sr[AceType.UI, UIRight.Operate].AccessAllowed )
			{
				_lastSelectedIndex = this.SelectedIndex;
				_lastText = this.Text;

				_va.ProcessEvent( this.Text, ControlEvents.TextChanged, true );

				base.OnTextChanged( e );
			}
			else
			{
				this.SelectedIndex = _lastSelectedIndex;
				this.Text = _lastText;
			}
		}

		//lovely:
		//cannot override inherited member 'System.Windows.Forms.DomainUpDown.OnSelectedItemChanged(object, System.EventArgs)' 
		//because it is not marked virtual, abstract, or override
		//( protected override void OnSelectedItemChanged(object source, EventArgs e) )
		new protected void OnSelectedItemChanged(object source, EventArgs e)
		{
			_sa.AuditAction( AuditType.ControlDetail, null, "SelectedItemChanged.", false );

			if( _sr[AceType.UI, UIRight.Operate].AccessAllowed )
			{
				_lastSelectedIndex = this.SelectedIndex;
				_lastText = this.Text;

				_va.ProcessEvent( this.Text, ControlEvents.SelectedItemChanged, true );

				base.OnSelectedItemChanged( source, e );
			}
			else
			{
				this.SelectedIndex = _lastSelectedIndex;
				this.Text = _lastText;
			}
		}
		#endregion


		#region Security Implementation
		[TypeConverter( typeof( ExpandableObjectConverter ) ),
		DesignerSerializationVisibility( DesignerSerializationVisibility.Content ),
		Description( "Provides access to Security management properties and tools." ), Category( "Suplex" )]
		public SecurityAccessor Security
		{
			get { return _sa; }
		}

		public void ApplySecurity()
		{
			if( !this.DesignMode )
			{
				if( !_sr[AceType.UI, UIRight.Operate].AccessAllowed )
				{
					base.ReadOnly = true;
				}
				if( !_sr[AceType.UI, UIRight.Enabled].AccessAllowed )
				{
					base.Enabled = false;
				}
				if( !_sr[AceType.UI, UIRight.Visible].AccessAllowed )
				{
					base.Visible = false;
				}
			}
		}

		[DefaultValue( false )]
		new public bool Visible
		{
			get
			{
				return base.Visible;
			}
			set
			{
				if( _sr[AceType.UI, UIRight.Visible].AccessAllowed )
				{
					base.Visible = value;
				}
			}
		}

		[DefaultValue( false )]
		new public bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				if( _sr[AceType.UI, UIRight.Enabled].AccessAllowed )
				{
					base.Enabled = value;
				}
			}
		}

		[DefaultValue( false )]
		new public bool ReadOnly
		{
			get
			{
				return base.ReadOnly;
			}
			set
			{
				if( _sr[AceType.UI, UIRight.Operate].AccessAllowed )
				{
					base.ReadOnly = value;
				}
			}
		}

		protected override void OnClick(EventArgs e)
		{
			if( _sr[AceType.UI, UIRight.Operate].AccessAllowed )
			{
				base.OnClick( e );
			}
		}
		#endregion
	}	//class
}	//namespace