using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // api/calculater/add?x=10&y=20
        public int Add(int x, int y)
        {
            return x + y;
        }
        // api/calculater/subtract?x=200&y=100
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        // api/calculater/multiply?x=10&y=20
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        // api/calculater/divide?x=10&y=20

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
    
