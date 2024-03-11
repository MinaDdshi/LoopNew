using System.ComponentModel.DataAnnotations;

namespace LoopAcademyProject.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
