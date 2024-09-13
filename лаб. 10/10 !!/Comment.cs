using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; } // Поле для связи с пользователем
        public User User { get; set; } // Навигационное свойство для доступа к связанному пользователю
    }
}
