using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Address Line 1:")]
        public string AddressLine1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line 2:")]
        public string AddressLine2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string AddressCity { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string AddressState { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Country:")]
        public string AddressCountry { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Zip Code:")]
        public string AddressZipCode { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "County:")]
        public string AddressCounty { get; set; }

        public static RegisterViewModel JoinModels(RegisterViewModel lModel, RegisterViewModel rModel)
        {
            RegisterViewModel model = new RegisterViewModel();
            model.FirstName = lModel.FirstName ?? rModel.FirstName;
            model.LastName = lModel.LastName ?? rModel.LastName;
            model.MiddleName = lModel.MiddleName ?? rModel.MiddleName;
            model.AddressLine1 = lModel.AddressLine1 ?? rModel.AddressLine1;
            model.AddressLine2 = lModel.AddressLine2 ?? rModel.AddressLine2;
            model.AddressCity = lModel.AddressCity ?? rModel.AddressCity;
            model.AddressState = lModel.AddressState ?? rModel.AddressState;
            model.AddressCountry = lModel.AddressCountry ?? rModel.AddressCountry;
            model.AddressZipCode = lModel.AddressZipCode ?? rModel.AddressZipCode;
            model.AddressCounty = lModel.AddressCounty ?? rModel.AddressCounty;
            return model;
        }

        static public List<SelectListItem> Countries = new List<SelectListItem>()
    {
        new SelectListItem() {Text = "Select a Country" , Value = ""},
        new SelectListItem() {Text = "USA" , Value = "US"},
        new SelectListItem() {Text = "Afghanistan" , Value = "AF"},
        new SelectListItem() {Text = "Albania" , Value = "AA"},
        new SelectListItem() {Text = "Algeria" , Value = "AN"},
        new SelectListItem() {Text = "American Samoa Islands" , Value = "AM"},
    };

        static public List<SelectListItem> States = new List<SelectListItem>()
    {
        new SelectListItem() {Text = "Select State" , Value = ""},
        new SelectListItem() {Text = "Alabama" , Value = "Alabama"},
        new SelectListItem() {Text = "Alaska" , Value = "Alaska"},
        new SelectListItem() {Text = "Arizona" , Value = "Arizona"},
        new SelectListItem() {Text = "Arkansas" , Value = "Arkansas"},
        new SelectListItem() {Text = "California" , Value = "California"},
        new SelectListItem() {Text = "Colorado" , Value = "Colorado"},
        new SelectListItem() {Text = "Connecticut" , Value = "Connecticut"},
        new SelectListItem() {Text = "Delaware" , Value = "Delaware"},
        new SelectListItem() {Text = "Florida" , Value = "Florida"},
        new SelectListItem() {Text = "Georgia" , Value = "Georgia"},
        new SelectListItem() {Text = "Hawaii" , Value = "Hawaii"},
        new SelectListItem() {Text = "Idaho" , Value = "Idaho"},
        new SelectListItem() {Text = "Illinois" , Value = "Illinois"},
        new SelectListItem() {Text = "Indiana" , Value = "Indiana"},
        new SelectListItem() {Text = "Iowa" , Value = "Iowa"},
        new SelectListItem() {Text = "Kansas" , Value = "Kansas"},
        new SelectListItem() {Text = "Kentucky" , Value = "Kentucky"},
        new SelectListItem() {Text = "Louisiana" , Value = "Louisiana"},
        new SelectListItem() {Text = "Maine" , Value = "Maine"},
        new SelectListItem() {Text = "Maryland" , Value = "Maryland"},
        new SelectListItem() {Text = "Massachusetts" , Value = "Massachusetts"},
        new SelectListItem() {Text = "Michigan" , Value = "Michigan"},
        new SelectListItem() {Text = "Minnesota" , Value = "Minnesota"},
        new SelectListItem() {Text = "Mississippi" , Value = "Mississippi"},
        new SelectListItem() {Text = "Missouri" , Value = "Missouri"},
        new SelectListItem() {Text = "Montana" , Value = "Montana"},
        new SelectListItem() {Text = "Nebraska" , Value = "Nebraska"},
        new SelectListItem() {Text = "Nevada" , Value = "Nevada"},
        new SelectListItem() {Text = "New Hampshire" , Value = "New Hampshire"},
        new SelectListItem() {Text = "New Jersey" , Value = "New Jersey"},
        new SelectListItem() {Text = "New Mexico" , Value = "New Mexico"},
        new SelectListItem() {Text = "New York" , Value = "New York"},
        new SelectListItem() {Text = "North Carolina" , Value = "North Carolina"},
        new SelectListItem() {Text = "North Dakota" , Value = "North Dakota"},
        new SelectListItem() {Text = "Ohio" , Value = "Ohio"},
        new SelectListItem() {Text = "Oklahoma" , Value = "Oklahoma"},
        new SelectListItem() {Text = "Oregon" , Value = "Oregon"},
        new SelectListItem() {Text = "Pennsylvania" , Value = "Pennsylvania"},
        new SelectListItem() {Text = "Rhode Island" , Value = "Rhode Island"},
        new SelectListItem() {Text = "South Carolina" , Value = "South Carolina"},
        new SelectListItem() {Text = "South Dakota" , Value = "South Dakota"},
        new SelectListItem() {Text = "Tennessee" , Value = "Tennessee"},
        new SelectListItem() {Text = "Texas" , Value = "Texas"},
        new SelectListItem() {Text = "Utah" , Value = "Utah"},
        new SelectListItem() {Text = "Vermont" , Value = "Vermont"},
        new SelectListItem() {Text = "Virginia" , Value = "Virginia"},
        new SelectListItem() {Text = "Washington" , Value = "Washington"},
        new SelectListItem() {Text = "West Virginia" , Value = "West Virginia"},
        new SelectListItem() {Text = "Wisconsin" , Value = "Wisconsin"},
        new SelectListItem() {Text = "Wyoming" , Value = "Wyoming"},
        new SelectListItem() {Text = "Washington DC" , Value = "Washington DC"}
    };
    }
}