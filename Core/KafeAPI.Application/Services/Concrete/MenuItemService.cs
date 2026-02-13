using AutoMapper;
using KafeAPI.Application.Dtos.MenuItemDtos;
using KafeAPI.Application.Interfaces;
using KafeAPI.Application.Services.Abstract;
using KafeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeAPI.Application.Services.Concrete
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IGenericRepository<MenuItem> _menuItemRepository;
        private readonly IMapper _mapper;

        public MenuItemService(IGenericRepository<MenuItem> menuItemRepository, IMapper mapper)
        {
            _menuItemRepository = menuItemRepository;
            _mapper = mapper;
        }

        public async Task AddMenuItem(CreateMenuItemDto dto)
        {
            var menuItem = _mapper.Map<MenuItem>(dto);
            await _menuItemRepository.AddAsync(menuItem);
        }

        public async Task DeleteMenuItem(int id)
        {
            var menuItem = await _menuItemRepository.GetByIdAysnc(id);
            await _menuItemRepository.DeleteAsync(menuItem);
        }

        public async Task<List<ResultMenuItemDto>> GetAllMenuItems()
        {
            var menuItems = await _menuItemRepository.GetAllAsync();
            var result = _mapper.Map<List<ResultMenuItemDto>>(menuItems);
            return result;
        }
        
        public async Task<DetailMenuItemDto> GetByIdMenuItem(int id)
        {
            var menuItems = await _menuItemRepository.GetByIdAysnc(id);
            var result = _mapper.Map<DetailMenuItemDto>(menuItems);
            return result;
        }

        public async Task UpdateMenuItem(UpdateMenuItemDto dto)
        {
            var menuItem = _mapper.Map<MenuItem>(dto);
            await _menuItemRepository.UpdateAsync(menuItem);
        }
    }
}
