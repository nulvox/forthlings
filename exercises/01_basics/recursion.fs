\ Exercise 09: Recursive Functions
\ Objective: Learn recursion in Forth

\ Documentation References:
\ 1. Recursion: https://www.gnu.org/software/gforth/manual/html_node/Recursion.html
\ 2. Conditional Recursion: https://www.gnu.org/software/gforth/manual/html_node/Conditional-Recursion.html

\ Instructions:
\ 1. Create a recursive factorial function
\ 2. Calculate 5 factorial
\ 3. Output the result

: factorial ( n -- n! )
  dup 1 > if
    dup 1- recurse *
  else
    drop 1
  then ;

5 factorial
." 5! is " . cr