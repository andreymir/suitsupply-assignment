using System;
using StringParser.Domain;
using StringParser.Interfaces;
using StringParser.Results;

namespace StringParser.Services
{
  public class ParseService : IParseService
  {
    public ParseResult ConvertFromText(string data)
    {
      try
      {
          var result = new ParseResult { Success = false };
          var fields = data.Split(',');
          
          var entity = new Entity
          {
              User = fields[0],
              Operand1 = int.Parse(fields[1]),
              Operand2 = int.Parse(fields[2]),
              Operator = Enum.Parse<EOperator>(fields[3]),
              OperationResult = int.Parse(fields[4]),
              OperationMessage = fields[5],
              RandomMessage = fields[6],
          };

          result.Message = "ok";
          result.Success = true;
          result.Entity = entity;

          return result;
      }
      catch (Exception ex)
      {
          return new ParseResult
          {
              Success = false,
              Message = ex.Message,
          };
      }
    }
  }
}