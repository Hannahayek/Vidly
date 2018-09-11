using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }


        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }


        
        public byte MembershipTypeId { get; set; }
       
        // we shouldnt add property for membershiptype so we created class membershipTypeDTO
        public MembershipTypeDto MembershipType { get; set; }

        [Display(Name = "Date of Birth")]
        //comment this when use ihttpaction result, will cause expeption 
        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }




    }
}