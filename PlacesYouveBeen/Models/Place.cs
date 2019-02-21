using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _cityName;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName)
    {
      _cityName = cityName;
      _instances.Add(this); // adding this to the instance list
      _id = _instances.Count;
    }
    
    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    } 

    public static void ClearAll() //Static means you are editing the class as a whole instead of a single instance of an object
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public int GetId()
    {
      return _id;
    }

  }
}