//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseContent
{
    using System;
    using System.Collections.Generic;
    
    public partial class reactiontestscore
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Score { get; set; }
    
        public virtual user user { get; set; }
    }
}
