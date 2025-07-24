\ Exercise 07: Conditional Execution
\ Objective: Learn conditional branching in Forth

\ Documentation References:
\ 1. Conditionals: https://www.gnu.org/software/gforth/manual/html_node/Conditionals.html
\ 2. Comparison Words: https://www.gnu.org/software/gforth/manual/html_node/Comparison.html

\ Instructions:
\ 1. Compare two numbers and output which is larger
\ 2. Use if/else/then structure
\ 3. Output appropriate message

: larger ( n1 n2 -- )
  2dup
  > if
    . ." is larger than " . cr
  else
    . ." is not larger than " . cr
  then ;

10 5 larger
15 20 larger