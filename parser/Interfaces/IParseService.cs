using StringParser.Results;

namespace StringParser.Interfaces
{
  public interface IParseService
  {
    ParseResult ConvertFromText(string data);
  }
}