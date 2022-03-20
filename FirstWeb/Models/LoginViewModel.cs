using System.ComponentModel.DataAnnotations;

namespace FirstWeb.Models
{
    public class LoginViewModel
    {
        [Required] 
        [Display(Name = "Логин")] 
        public string UserName { get; set; }
        
        [Required] 
        [UIHint("password")] 
        [Display(Name = "Пароль")] 
        public string Password { get; set; }
        
        [Display(Name = "Запомните меня?")] 
        public bool RememberMe { get; set; }
    }
}