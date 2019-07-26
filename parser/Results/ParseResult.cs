using StringParser.Domain;

namespace StringParser.Results
{
  public class ParseResult
  {
    public bool Success { get; set; }
    public string Message { get; set; }
    public Entity Entity { get; set; }
  }
}