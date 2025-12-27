// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
quantity = input.Remove(input.IndexOf("<div>"), input.IndexOf("5000"));
output = input.Replace("</div>", "")
    .Replace("<div>", "");

Console.WriteLine("Quantity: " + quantity.Remove(4, 13));
Console.WriteLine("Output: " + output);