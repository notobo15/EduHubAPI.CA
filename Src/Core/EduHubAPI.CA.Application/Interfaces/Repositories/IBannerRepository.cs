using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Domain.Banners.Entities;
using EduHubAPI.CA.Domain.Banners.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.Repositories
{
    public interface IBannerRepository : IGenericRepository<Banner>
    {
        Task<PaginationResponseDto<BannerDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
