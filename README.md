# Objectives

- Create 2 endpoints, /api/accum and api/explosion, that are based off of the katas,[https://www.codewars.com/kata/mumbling](https://www.codewars.com/kata/mumbling) and [https://www.codewars.com/kata/digits-explosion](https://www.codewars.com/kata/digits-explosion) respectfully.
- Working with EF Core
- Creating a simple API

# Includes: 

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- [EF CORE](https://docs.microsoft.com/en-us/ef/core/)
- [CONTROLLERS](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.controller?view=aspnet-mvc-5.2)
- [POSTMAN](https://www.postman.com/)
- MVC design pattern

## Featured Code

### Kata controller

```C#
 public class KataController : ControllerBase
  {
      [HttpGet("explode")]
      public string Explode(string s)
      {
          return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));

      }

      [HttpGet("accum")]
      public string Accum(string s)
      {
          return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
      }
  }
 ```
