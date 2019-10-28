using System.Collections.Generic;

namespace RiversAPI.Models
{
    public class River
    {
        public int RiverId { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public string Source { get; set; }
        public string Mouth { get; set; }
        public string Flow { get; set; }
        public string States { get; set; }
        public string Tributaries { get; set; }
    }
}