namespace EAD1_CA_3_X00149830
{
    public class Root
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public int Code { get; set; }

       

        //extracts the type of dog from the url by removing leadURL and then removing everything after the /
        public string ExtractDogType(string dogImageURL)
        {
            string leadURL = "https://images.dog.ceo/breeds/";

            string dogType = dogImageURL.Remove(0, leadURL.Length);

            int firstForwardSlash = dogType.IndexOf('/');

            dogType = dogType.Remove(firstForwardSlash);

            return dogType;
        }

        //Formats the dog type extracted from the response URL
        public string FormatDogType(string dogType)
        {
            //Capitalizes the first letter of the dog type
            dogType = char.ToUpper(dogType[0]) + dogType[1..];

            //if the dog type has a sub breed it is joined with a hyphen and the breed is first for example terrier-silky
            //this check for the hyphen, substrings dog type into breed and sub breed, then capitilzes sub breed
            //finally changes dogtype to the more familiar subBreed Breed format we are used to.

            if (dogType.Contains('-'))
            {
                string breed, subBreed;
                int hyphenLoc = dogType.IndexOf('-');
                breed = dogType.Substring(0, hyphenLoc);
                subBreed = dogType[(hyphenLoc + 1)..];

                subBreed = char.ToUpper(subBreed[0]) + subBreed[1..];

                return  subBreed + " " + breed;
            }

            return dogType;
        }

    }
}
