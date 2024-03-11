using LoopAcademyProject.DatabaseContext.Repository;
using LoopAcademyProject.Entities;

namespace LoopAcademyProject.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userRepository;
        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Create(string Id, User create)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                var user = new User
                {
                    Id = create.Id,
                    UserName = create.UserName,
                    Name = create.Name,
                    SurName = create.SurName,
                    PhoneNumber = create.PhoneNumber,
                    Birth = create.Birth,
                    NationalCode = create.NationalCode,
                };
                await _userRepository.Insert(user);
                return true;
            }
            return false;
        }

        public async Task<User> Read(string Id)
        {
            var user = await _userRepository.Select(Id);

            return new User
            {
                Id = user.Id,
                UserName = user.UserName,
                Name = user.Name,
                SurName = user.SurName,
                PhoneNumber = user.PhoneNumber,
                Birth = user.Birth,
                NationalCode = user.NationalCode,
            };
        }

        public async Task<List<User>> ReadAll(string Id)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                var user = await _userRepository.SelectAll();

                return user.Select(x => new User
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Name = x.Name,
                    SurName = x.SurName,
                    PhoneNumber = x.PhoneNumber,
                    Birth = x.Birth,
                    NationalCode = x.NationalCode,
                }).ToList();
            }
            return null;
        }

        public async Task Update(User update)
        {
            var user = await _userRepository.Select(update.Id);
            user.Id = update.Id;
            user.UserName = update.UserName;
            user.Name = update.Name;
            user.SurName = update.SurName;
            user.PhoneNumber = update.PhoneNumber;
            user.Birth = update.Birth;
            user.NationalCode = update.NationalCode;
            await _userRepository.Update(user);
        }

        public async Task Delete(string Id)
        {
            await _userRepository.Delete(Id);
        }
    }
}
