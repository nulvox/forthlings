\ Exercise 08: Looping Constructs
\ Objective: Learn to use loops in Forth

\ Documentation References:
\ 1. Loops: https://www.gnu.org/software/gforth/manual/html_node/Loops.html
\ 2. Begin-Words: https://www.gnu.org/software/gforth/manual/html_node/Begin-Words.html

\ Instructions:
\ 1. Create a loop that counts from 1 to 5
\ 2. Output each number in the loop
\ 3. Use DO +LOOP structure

: count-to-5
  5 1 do
    i .
  loop cr ;

count-to-5