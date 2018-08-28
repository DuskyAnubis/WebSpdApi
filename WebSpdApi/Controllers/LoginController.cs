using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebSpdApi.Data;

namespace WebSpdApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/Login")]
    [Authorize]
    public class LoginController : Controller
    {
        private readonly ApiContext dbContext;
        private readonly IMapper mapper;

        public LoginController(ApiContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        /// <summary>
        /// 根据Token,得到登录用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(void), 500)]
        public async Task<IActionResult> GetUser()
        {


            return new ObjectResult("");
        }
    }
}