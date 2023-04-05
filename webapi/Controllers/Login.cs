using Chat.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;

using static System.Net.Mime.MediaTypeNames;

namespace Chat.WebApi.Controllers
{
   
    [Route("/api/Login")]
    [ApiController]
    public class Login : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public Login(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet("{id}")]
        public User GetById(int id)
        {
           User user = unitOfWork.UserRepository.GetById(id);
            return user;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]User request)
        {
           var user = unitOfWork.UserRepository.GetByMail(request.Email);

            if (user == null)
            {
                return BadRequest(new { Message = "Giriş başarısız. Lütfen kullanıcı adı ve şifrenizi kontrol edin." });
            }else if (user.Password != request.Password)
            {
                return BadRequest(new { Message = "Giriş başarısız. Lütfen kullanıcı adı ve şifrenizi kontrol edin." });

            }

            else
            if (user.isActive == false)
            {
                return BadRequest(new { Message = "Not Activated" });

            }
            else if (user.Password == request.Password) { return Ok(new { Message = "Giriş başarılı" });
            }
            else 
            return BadRequest(new { Message = "Hata Oluştu" });
        }

      
        
    }
}
