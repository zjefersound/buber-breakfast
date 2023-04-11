using BuberBreakfast.Models;
using ErrorOr;
using BuberBreakfast.ServiceErrors;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{

    private readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }
    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (_breakfasts.TryGetValue(id, out var breakfast))
        {

            return _breakfasts[id];
        }
        return Errors.Breakfast.NotFound;
    }
    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);

    }
}