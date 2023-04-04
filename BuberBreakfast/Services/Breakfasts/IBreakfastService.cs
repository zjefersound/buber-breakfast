using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    // BreakfastResponse GetBreakfast(Guid id);
    // BreakfastResponse UpdateBreakfast(Guid id, CreateBreakfastRequest request);
    // BreakfastResponse DeleteBreakfast(Guid id);

}