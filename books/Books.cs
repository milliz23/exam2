//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace books
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int IDGanre { get; set; }
        public string Author { get; set; }
        public int KolvMagaz { get; set; }
        public int KolvSkl { get; set; }
        public string Opis { get; set; }
        public string Image { get; set; }
        public Nullable<decimal> Prise { get; set; }
    
        public virtual Ganre Ganre { get; set; }
    }
}