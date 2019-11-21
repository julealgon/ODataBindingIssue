using System.ComponentModel.DataAnnotations;

namespace julealgon.ODataBindingIssues.Entities
{
    public sealed class Entity
    {
        [Key]
        public int ThisIsAKey { get; set; }
    }
}
