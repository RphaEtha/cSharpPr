InputData의 Type Checking
TryParse: 문자열을 특정 데이터 타입으로 변환을 시도하고 변환이 성공하면 'true'를 실패하면 'false'를 반환한다.

  bool success = 데이터타입.TryParse(입력된문자열, out 변환된 값);

Read를 통해 입력 받은 값을 if 문을 사용하여 여러 경우로 나누어 타입 캐스팅을 수행 예시
---------------------------------------------------------------------------
  Console.WriteLine("값을 입력하세요:");
  string input = Console.ReadLine();

  if (int.TryParse(input, out int intValue))
  {
      // 입력된 값이 정수인 경우
      Console.WriteLine("입력된 값은 정수입니다.");
      // intValue 변수를 사용하여 정수 관련 작업 수행
  }
  else if (double.TryParse(input, out double doubleValue))
  {
      // 입력된 값이 부동 소수점 숫자인 경우
      Console.WriteLine("입력된 값은 부동 소수점 숫자입니다.");
      // doubleValue 변수를 사용하여 부동 소수점 숫자 관련 작업 수행
  }
  else if (DateTime.TryParse(input, out DateTime dateValue))
  {
      // 입력된 값이 날짜 및 시간 형식인 경우
      Console.WriteLine("입력된 값은 날짜 및 시간 형식입니다.");
      // dateValue 변수를 사용하여 날짜 및 시간 관련 작업 수행
  }
  else
  {
      // 입력된 값이 위의 경우에 해당하지 않는 경우
      Console.WriteLine("입력된 값은 다른 형식입니다.");
      // 추가적인 처리 로직 수행
  }

