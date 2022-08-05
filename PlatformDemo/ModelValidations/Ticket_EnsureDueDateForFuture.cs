using PlatformDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.ModelValidations
{
    public class Ticket_EnsureDueDateForFuture:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;

            if(ticket.DueDate <= DateTime.Now)
            {
                return new ValidationResult("Due date must be greater than the current time");
            }

            return ValidationResult.Success;
        }
    }
}
