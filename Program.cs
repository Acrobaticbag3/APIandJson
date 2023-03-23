using Newtonsoft.Json;
using RestSharp;

var client = new RestClient("https://api.nobelprize.org/2.1/laureates");
            var request = new RestRequest("/", Method.Get);
            RestResponse response = client.Execute(request);
            String content = response.Content;

Root menu = JsonConvert.DeserializeObject<Root>(content); // Byt ut till er eget huvudobjekt

for (int i = 0; i < 25; i++) {
    Console.WriteLine(i+1+ ". " + menu.laureates[i].fullName.en);
}

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Affiliation {
        public Name name { get; set; }
        public NameNow nameNow { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public CityNow cityNow { get; set; }
        public CountryNow countryNow { get; set; }
        public LocationString locationString { get; set; }
    }

    public class Birth {
        public string date { get; set; }
        public Place place { get; set; }
    }

    public class Category {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class CategoryFullName {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class City {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class CityNow {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
        public List<string> sameAs { get; set; }
    }

    public class Continent {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class Country {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
        public string sameAs { get; set; }
    }

    public class CountryNow {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
        public List<string> sameAs { get; set; }
    }

    public class Death {
        public string date { get; set; }
        public Place place { get; set; }
    }

    public class FamilyName {
        public string en { get; set; }
        public string se { get; set; }
    }

    public class FullName {
        public string en { get; set; }
        public string se { get; set; }
    }

    public class GivenName {
        public string en { get; set; }
        public string se { get; set; }
    }

    public class KnownName {
        public string en { get; set; }
        public string se { get; set; }
    }

    public class Laureate {
        public string id { get; set; }
        public KnownName knownName { get; set; }
        public GivenName givenName { get; set; }
        public FamilyName familyName { get; set; }
        public FullName fullName { get; set; }
        public string fileName { get; set; }
        public string gender { get; set; }
        public Birth birth { get; set; }
        public Wikipedia wikipedia { get; set; }
        public Wikidata wikidata { get; set; }
        public List<string> sameAs { get; set; }
        public List<Link> links { get; set; }
        public List<NobelPrize> nobelPrizes { get; set; }
        public Death death { get; set; }
    }

    public class Link {
        public string rel { get; set; }
        public string href { get; set; }
        public string action { get; set; }
        public string types { get; set; }
        public string title { get; set; }
        public List<string> @class { get; set; }
        public string first { get; set; }
        public string self { get; set; }
        public string next { get; set; }
        public string last { get; set; }
    }

    public class LocationString {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class Meta  {
        public int offset { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string disclaimer { get; set; }
    }

    public class Motivation {
        public string en { get; set; }
        public string se { get; set; }
        public string no { get; set; }
    }

    public class Name {
        public string en { get; set; }
        public string no { get; set; }
        public string se { get; set; }
    }

    public class NameNow {
        public string en { get; set; }
    }

    public class NobelPrize {
        public string awardYear { get; set; }
        public Category category { get; set; }
        public CategoryFullName categoryFullName { get; set; }
        public string sortOrder { get; set; }
        public string portion { get; set; }
        public string dateAwarded { get; set; }
        public string prizeStatus { get; set; }
        public Motivation motivation { get; set; }
        public int prizeAmount { get; set; }
        public int prizeAmountAdjusted { get; set; }
        public List<Affiliation> affiliations { get; set; }
        public List<Link> links { get; set; }
        public List<Residence> residences { get; set; }
    }

    public class Place {
        public City city { get; set; }
        public Country country { get; set; }
        public CityNow cityNow { get; set; }
        public CountryNow countryNow { get; set; }
        public Continent continent { get; set; }
        public LocationString locationString { get; set; }
    }

    public class Residence {
        public Country country { get; set; }
        public CountryNow countryNow { get; set; }
        public LocationString locationString { get; set; }
    }

    public class Root {
        public List<Laureate> laureates { get; set; }
        public Meta meta { get; set; }
        public Links links { get; set; }
    }

    public class Wikidata {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Wikipedia {
        public string slug { get; set; }
        public string english { get; set; }
    }

    public class Links {
        public string self { get; set; }
        public string first { get; set; }
        public string next { get; set; }
        public string last { get; set; }
    }

