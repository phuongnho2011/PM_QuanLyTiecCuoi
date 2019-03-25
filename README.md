# PM_QuanLyTiecCuoi

Library-Management
Feature:
I. Introduction

II.Function

1. Register library card
2. Register new book
3. Browsing
4. Lending book
5. Returning book
6. Report
7. Regulations
III. Example

IV. FAQ & Usage

V. Support

VI. Contributing

===========================

I. Introduction:
A free library-managing app created by TNQN1998 team. This app is made exclusively for the librarian to manage and running the library smoothly


II. Function:

1. Register library card
Information about library card:

Member's name
Reader's category
Birthday
Address
Email
Register Day
•	Step 01: Access database.

•	Step 02: Load the existent data.

•	Step 03: Read the input from user.

•	Step 04: Check the input with the existent data (“Reader's category ”…).

•	Step 05: Calculate reader's age.

•	Step 06: Check the requirement of minimum age.

•	Step 07: Check the requirement of maximum age.

•	Step 08: If the requirements are not met skip to step 12.

•	Step 09: Calculate the expiration date.

•	Step 10: Store the user's info into database.

•	Step 11: Print result.

•	Step 12: Close connection.

•	Step 13: Finish.


2. Register new book
•	D1: Book's info: Title, Category, Author, Publication date, Publisher, Receipt date, Cost.

•	D2: None.

•	D3: List of book's category + author.

•	D4: D1.

•	D5: D4.

•	D6: List of book's category + author.

•	Step 01: Access database.

•	Step 02: Load the existent data.

•	Step 03: Read the input from user.

•	Step 04: Check input ("Category,....").

•	Step 05: Check the requirement of the category "Less then 8 years".

•	Step 06: Check the requirement of the category "More then 8 years" .

•	Step 07: If the requirements are not met skip to step 10.

•	Step 08: Store the user's info into database.

•	Step 09: Print result.

•	Step 10: Close connection.

•	Step 11: Finish.


3. Browsing
•	D1: Check the standard for browsing (“Code”, “Title”, “Category”,”Author”,”Status”)

•	D2: None.

•	D3: Result table (“ID”,“Code”, “Title”, “Category”,”Author”,”Status”).

•	D4: None.

•	D5: D3.

•	D6: D3.

•	Step 01: Read the input from user.

•	Step 02: Access database.

•	Step 03: Read D3 from secondary memory.

•	Step 04: Print result.

•	Step 05: Return input back to user.

•	Step 06: Close connection.

•	Step 07: Finish.


4. Lending book
•	D1: User's requested info: “Name”, “Date”.

•	D2: None.

•	D3: List of books met requirement.

•	D4: D1.

•	D5: D4.

•	Bước 01: Access Database.

•	Bước 02: Read info from secondary mem.

•	Bước 03: Read input from user.

•	Bước 04: Check the input (“ Name”, “Lending date”…).

•	Bước 05: Check the regulation “Expiration Date”.

•	Bước 06: Check the regulation “Không có sách mượn quá hạn”.

•	Bước 07: Check the regulation “Sách không có nguòi đang mượn”.

•	Bước 08: Check the regulation “Mỗi độc giả muộn tối đa 5 quyển sách trong 4 ngày”.

•	Bước 09: If the requirements are not met skip to step 13.

•	Bước 10: Calculate the expiration day.

•	Bước 11: Store the user's info into database.

•	Bước 12: Print result.

•	Bước 13: Close connection.

•	Bước 14: Finish.


5. Returning book

6. Report

7. Regulations

III. Example:

IV. FAQ & Usage:

V. Support:

VI. Contributing: