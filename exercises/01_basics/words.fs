\ Exercise 05: Words and Definitions
\ Objective: Learn to define new words in Forth

\ Documentation References:
\ 1. Defining Words: https://www.gnu.org/software/gforth/manual/html_node/Defining-Words.html
\ 2. Colon Definitions: https://www.gnu.org/software/gforth/manual/html_node/Colon-Definitions.html

\ Instructions:
\ 1. Define a word 'square' that squares a number
\ 2. Use the word to calculate 5 squared
\ 3. Output the result

: square ( n -- n^2 )
  dup * ;

5 square
\ TODO: Add output statement here

." 5 squared is " . cr