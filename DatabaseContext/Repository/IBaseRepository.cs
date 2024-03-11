using LoopAcademyProject.Entities;

namespace LoopAcademyProject.DatabaseContext.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity<string>
    {
        Task Insert(TEntity entity);
        Task<TEntity> Select(string Id);
        Task<List<TEntity>> SelectAll();
        Task Update(TEntity entity);
        Task Delete(string Id);
    }
}
