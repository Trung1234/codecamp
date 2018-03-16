
# Codecamp 2 của lớp C# 

## Bài 1: Dựng 1 Guess a Number game

Dựng 1 game console đoán số, chương trình tự sinh ra 1 số nguyên ngẫu nhiên trong phạm vi từ -100 đến 100. Người dùng được yêu cầu đoán số. Chương trình theo dõi số lượt người chơi đoán.

* Nếu số nhập vào > kết quả -> thông báo cho người chơi là "Guess Lower"
* Nếu số nhập vào < kết quả -> thông báo cho người chơi là "Guess Higher"
* Nếu số nhập vào = kết quả -> thông báo cho người chơi là "You win with ... guesses. The correct number is:..."

## Bài 2: luyện thiết kế class, tạo properties, methods, sử dụng kiểu List<T>

In this assignment, tạo đối tượng cho ứng dụng của một trường học thể hiện thông tin của 1 chương trình học. Ví dụ, chương trình học (UProgram) là Computer Science, trong chương trình này có nhiều kiểu bằng (Degree) khác nhau (Bachelor, Master, etc.), và các lớp thể hiện khóa học (Course), giáo viên (Teacher), và học sinh (Student) đều là 1 phần của trường học. Bạn sẽ cần tạo các class dưới đây, mỗi class ở 1 file riêng:

A Student
A Teacher
A UProgram (C# mặc định dùng Program là class chứa Main() nên đặt tên UProgram để không trùng)
A Degree
A Course

Tạo mỗi class với các thuộc tính, phương thức phù hợp.

Một đối tượng của lớp Course có thể có nhiều Student và Teacher, đảm bảo khai báo thuộc tính trong lớp Course phù hợp để có thể lưu nhiều đối tượng của lớp Student và Teacher. 

UProgram sẽ có thể lưu nhiều degrees và degree có nhiều courses. Sử dụng diagram dưới đây để hiểu quan hệ giữa các lớp:

![img](uprogram-class-diagram.png)

Class diagram thể hiện các lớp Program, Degree, Course, Student, và Teacher theo tầng khi UProgram ở trên cùng lớn nhất sẽ bao gồm nhiều Degree và Degree thì gồm nhiều Course, trong Course thì lại có thể lưu nhiều Student và Teacher

Trong mỗi lớp này sẽ có 1 biến và phương thức static để theo dõi tổng số lượng các đối tượng được tạo ra từ 1 class. Số lượng đối tương sẽ được tăng mỗi khi một đối tượng mới được khởi tạo.

Trong Main() của file Program.cs, tiến hành các bước sau:

* Khởi tạo 1 đối tượng UProgram tên là Information Technology.
*  Khởi tạo 1 đối tượng Degree gọi là `Bachelor` (bằng cử nhân), trong đối tượng UProgram (UProgram có thể có lớp UProgram1.CreateDegree() để khởi tạo 1 degree mới thuộc đối tượng UProgram1 hoặc có thể khởi tạo 1 Degree sau đó UProgram có AddDegree() để thêm degree đó vào đối tượng UProgram được khởi tạo ở bước trước).
* Khởi tạo 1 đối tượng Course gọi là `Programming with C#` trong đối tượng Degree, tương tự ở trên Degree có thể có 1 phương thức CreateCourse() hoặc AddCourse().
* Khởi tạo 1 đối tượng Course gọi là `JavaScript for beginner`
* Khởi tạo tất cả 5 đối tượng Student và 2 Teacher, trong đó Course `Programming with C#` có 3 Student và 1 Teacher, Course `JavaScript for beginner` có 4 Student và 2 Teacher.
* Sử dụngConsole.WriteLine() để in ra các thông tin dưới đây ra terminal:
  * Tên của UProgram và Degree có trong UProgram này
  * Tên của các Course trong Degree
  * Tổng số lượng Student và Teacher trong trường
  * Số lượng và danh sách học sinh và giáo viên trong từng Course.

## Bài 3: Kiểm tra mảng số có phải là các số liền nhau không

Viết một chương trình yêu cầu người dùng nhập vào 1 mảng số nguyên và kiểm tra xem mảng này có chứa các số liền nhau không.

Ví dụ 1:
* Input: 1 2 3 4 5
* Ouput: "Yes. This is a consecutive array of numbers"

Ví dụ 2:
* Input: 1 2 3 4 5 10 9 8
* Ouput: "No. This is not a consecutive array of numbers"
