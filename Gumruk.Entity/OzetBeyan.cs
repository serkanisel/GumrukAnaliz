//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gumruk.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OzetBeyan
    {
        public int ID { get; set; }
        public Nullable<int> BeyanTuruId { get; set; }
        public string Rejim { get; set; }
        public Nullable<int> TasimaSekli { get; set; }
        public Nullable<int> GumrukIdaresi { get; set; }
        public Nullable<int> KalemSayisi { get; set; }
        public Nullable<int> EkBelgeSayisi { get; set; }
        public Nullable<int> IlkVarisCikisYeri { get; set; }
        public Nullable<System.DateTime> TescilTarihi { get; set; }
        public Nullable<System.DateTime> OnayTarihi { get; set; }
        public Nullable<System.DateTime> KapanisTarihi { get; set; }
        public Nullable<int> YuklemeUlkesiId { get; set; }
        public Nullable<int> YukelemeLimaniId { get; set; }
        public Nullable<int> BosaltmaUlkesiId { get; set; }
        public Nullable<int> BosaltmaLimanıId { get; set; }
        public Nullable<int> BeyanSahibiId { get; set; }
        public Nullable<int> TasiyiciFirmaId { get; set; }
        public Nullable<int> TasitID { get; set; }
        public string OncekiBeyanNoAnaKonsimentoNo { get; set; }
        public string GrupTasimaSenediNo { get; set; }
        public string TirAtaKarneNo { get; set; }
        public Nullable<bool> Kurye { get; set; }
        public Nullable<bool> EmniyetGuvenlik { get; set; }
        public string Diger { get; set; }
    }
}