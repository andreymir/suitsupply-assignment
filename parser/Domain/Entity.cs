namespace StringParser.Domain
{
  public class Entity
  {
    public string User { get; set; }
    public int Operand1 { get; set; }
    public int Operand2 { get; set; }
    public EOperator Operator { get; set; }
    public int OperationResult { get; set; }
    public string OperationMessage { get; set; }
    public string RandomMessage { get; set; }
  }
}