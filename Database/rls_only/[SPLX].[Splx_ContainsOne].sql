ALTER FUNCTION [SPLX].[Splx_ContainsOne](@sourceValue [binary](256), @compareValue [binary](256))
RETURNS [bit] WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME [Splx_BitLib].[BinaryUtil].[ContainsOne]