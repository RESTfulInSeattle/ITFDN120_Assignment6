Write a method that given two strings compares the string for equality.

Do not use the built-in string compare methods, you are trying to write those library functions.

define boolean function compare(one : string, two : string, caseInsensitive : boolean)

compare("hello", "hello", false) -> true
compare("hello", "hello", true) -> true
compare("hello", "HELLO", false) -> false
compare("hello", "HELLO", true) -> true