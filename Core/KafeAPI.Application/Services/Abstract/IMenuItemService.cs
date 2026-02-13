using KafeAPI.Application.Dtos.MenuItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeAPI.Application.Services.Abstract
{
    public interface IMenuItemService
    {
        Task<List<ResultMenuItemDto>> GetAllMenuItems();
        Task<DetailMenuItemDto> GetByIdMenuItem(int id);
        Task AddMenuItem(CreateMenuItemDto dto);
        Task UpdateMenuItem(UpdateMenuItemDto dto);
        Task DeleteMenuItem(int id);
    }
}
