\ Exercise 10: String Manipulation
\ Objective: Learn to work with strings in Forth

\ Documentation References:
\ 1. Strings: https://www.gnu.org/software/gforth/manual/html_node/Strings.html
\ 2. String Words: https://www.gnu.org/software/gforth/manual/html_node/String-Words.html

\ Instructions:
\ 1. Create and concatenate strings
\ 2. Output the combined string

create string1 s" Hello, "
create string2 s" Forthlings!"
create result 40 allot

: concat-strings ( -- )
  string1 count result place
  string2 count result +place
  result count type cr ;

concat-strings 