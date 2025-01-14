using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi501.Dtos;

namespace CharpEgitimKampi501.Repositories
{
    /*
     Async programlama bir uygulamanın uzun süren işlemleri
     (Örneğin dosya okuma,web istekleri,veritabanı işlemleri) beklerken
     uygulamasının yanıt vermeye devam etmesini sağlar.
    */
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(CreateProductDto createProductDto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}