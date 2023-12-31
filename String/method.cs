Length: 문자열의 길이 반환
  string str = "Hello World";
  int length = str.Length; // 11

ToLower, ToUpper: 문자열을 소문자로 변환하거나 대문자로 변환한다.
  string str = "Hello World";
  string lowerCase = str.ToLower(); // "hello world"
  string upperCase = str.ToUpper(); // "HELLO WORLD"

Trim, TrimStart, TrimEnd: 문자열의 앞 뒤 공백을 제거한다.
  string str = "     Hello World    ";
  string trimmed = str.Trim();      // "Hello World" 
  string trimmed = str.TrimStart(); // "Hello World    "
  string trimmed = str.TrimEnd(); // "     Hello World"

Substring: 문자열의 일부분을 추출한다.
  string str = "Hello World";
  string substr1 = str.Substring(6);    // "World"
  string substr2 = str.Substring(0, 5); // "Hello"

Split: 문자열을 구분자를 기준으로 나누어 문자열 배열로 반환한다.
  string str = "Hello, world";
  string[] parts = str.Split(',');     // ["Hello", "World"]

Replace: 문자열 내의 특정 문자나 문자열을 다른 문자나 문자열로 치환한다.
  string str = "Hello World";
  string replaced = str.Replace("Hello", "Hi");   // "Hi World"

Concat: 여러 개의 문자열을 결합한다.
  string str1 = "Hello";
  string str2 = "World";
  string combined = string.Contcat(str1, " ", str2); // "Hello World"

Join: 문자열 배열의 요소를 지정한 구분자로 결합한다.
  string[] arr = { "Hello", "World"};
  string joined = string.Join(" ", arr);            // "Hello World"

Contains: 문자열이 특정 문자열을 포함하는지 여부를 확인
  string str = "Hello World";
  bool contains = str.Contains("World");            // true

StartWith, EndsWith: 문자열이 특정 문자열로 시작하는지 또는 특정 문자열로 끝나는지 여부를 확인한다.
  string str = "Hello World";
  bool startWith = str.StartsWith("Hello");         // true
  bool endsWith = str.EndsWith("World);             // true

IndexOf, LastIndexOf: 특정 문자열이나 문자의 첫 번째 또는 마지막 등장 위치를 찾는다.
  string str = "Hello World";
  int firstIndex = str.IndexOf("o");                //4
  int lastIndex = str.LastIndexOf("o");             //7

Insert: 문자열의 지정된 위치에 다른 문자열을 삽입한다.
  string str = "Hello";
  string inserted = str.Insert(5, " World");       // "Hello World"

Remove: 문자열의 지장된 위치에서부터 지정된 개수의 문자를 제거한다.
  string str = "Hello World";
  string removed = str.Remove(5, 6);               // "Hello"

IsNullOrEmpty, IsNullOrWhiteSpace: 문자열이 null인지, 빈 문자열인지 또는 공백 문자열인지 확인한다.
  string str1 = null;
  string str2 = "";
  string str3 = "   ";
  bool isNullOrEmpty1 = string.IsNullOrEmpty(str1); //true
  bool isNullOrEmpty2 = string.IsNullOrEmpty(str2); //true
  bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str3) // true

IsDigit, IsLettter: 문자열이 숫자인지, 문자인지 여부를 확인한다.
  char ch1 = '7';
  char ch2 = 'A';
  bool isDigit = char.IsDigit(ch1);  // true
  bool isLetter = char.IsLetter(ch2); // true

ToCharArray: 문자열을 문자 배열로 변환한다.
  string str = "Hello";
  char[] charArray = str.ToCharArray(); // ['H', 'e', 'l', 'l', 'o']

IndexOfAny, LastIndexOfAny: 지정된 문자 배열의 어떤 문자가 문자열 내에서 첫 번째 또는 마지막으로 발견된 인덱스를 반환한다.
  string str = "Hello World";
  char[] chars { 'o', 'd'  }; 
  int firstIndex = str.IndexOfAny(chars); // 4 ('o')
  int lastIndex = str.LastIndexOfAny(chars); // 9 ('d')

IsUpper, IsLower: 문자열이 모두 대문자인지 또는 소문자인지 확인한다.
  string str1 = "HELLO";
  string str2 = "hello";
  bool isUpper = str1.IsUpper(); // true
  bool isLower = str2.IsLower(); // true
  for (int i = 0; i < str1.Length; i++){
    if (char.IsLower(str1[i])){
      result += str1[i].ToUpper();
    }
    else{
      result += str1[i].ToLower();
    }
  }


