Object-oriented programming. Sem 2. Assignment 2.
   
1.Загальні вимоги до розроблювальних програм: наявність найпростішого текстового інтерфейсу користувача; забезпечення коректної обробки вихідних даних із метою запобігання появи помилок при виконанні програми; розробка програми для обробки відомості. Для цього необхідно описати клас, поля якого відповідають вихідним полям відомості. Для установки значень полів повинен використовуватися конструктор. Обчислення значень розрахункових полів відомості, одержання значень вихідних полів повинне виконуватися за допомогою відповідних нестатичних методів класу. Програма повинна забезпечувати створення масиву об'єктів цього класу, уведення вихідних даних з консолі й вивід на консоль вихідних значень і полів, що розраховуються, кожної із записів відомості, а також підсумкової інформації з відомості.

![sem2 lab2](https://user-images.githubusercontent.com/114365042/232078005-770694f8-ddd9-47e5-91ce-f4c916329afd.png)

2.1 Перетворити програму обробки відомості (див. завдання 1) так, щоб у ній використовувалося відношення агрегації. При цьому "цілим" повинен бути клас, що подає відомість із безліччю записів, а "частиною" - клас, що подає один запис відомості. 
2.2 Розробити програму, що використовує принцип поліморфізму на базі абстрактного завдання на лабораторну роботу (див. нижче). 
2.3 Перетворити програму із завдання 2 так, щоб замість абстрактного класу використовувався інтерфейс.

Є відношення спадкування: судно (Vessel) – базова абстракція, парусник (SailingVessel) та підводний човен (Submarine) – похідні класи. Vessel має методи PrepareToMovement() (підготуватися до руху) та Move() (рухатися). Кожний із похідних класів перевизначає методи PrepareToMoving(), Move() базової абстракції. Розробити консольну програму, яка використовує принцип поліморфізму для виведення текстових повідомлень щодо підготовки до руху та руху парусника й підводного човна. 

3.Перевантажені операції для виконання обробки елементів вектора, повинна визначати:
1)Суму від’ємних елементів двох "векторів".
2)Добуток елементів двох "векторів" із парними номерами.
3)Кількість елементів двох "векторів", рівних 0.
       Programming. C#. Sem 2. Assignment 1. Text files and binary files.

Text files: 

Task 1.
Write a program to create a text file that contains 2 lines. 
The content of the file should be displayed on the screen.

Task 2.
Write a program that allows you to create a text file and write to it 15 random real numbers. 
The numbers should be on the same line. Find the maximum among them and write it into another file with the name max.txt

Task 3.
The text file contains arbitrary English words, 1 word per line, no more than 40 words in the file, the word length is limited to 80 characters. 
Rewrite words to another file by sorting them alphabetically.

Task 4.
The text file contains the names and surnames of the students and their scores in CSV format. Display all students whose score is less than 60 points. 
If such students are absent, display a message on the screen.

First Name 1, Last Name 1, 59
First Name 2, Last Name 2, 60
First Name 3, Last Name 3, 51
…

Task 5 (task from interview). 
Write a program that will calculate the number of each word in a text file.

Binary Files:

Task 6. 
Read a CSV file that is specified in Task 4, Create a binary file that is based on the CSV file. 
Read the binary file and create another binary file that will contain the number of the students whose score is greater than 95 and all the records for those students.

master
