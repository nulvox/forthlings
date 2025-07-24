\ Exercise 04: Variables and Memory
\ Objective: Learn to use variables in Forth

\ Documentation References:
\ 1. Variables: https://www.gnu.org/software/gforth/manual/html_node/Variables.html
\ 2. Memory: https://www.gnu.org/software/gforth/manual/html_node/Memory.html

\ Instructions:
\ 1. Create a variable called counter
\ 2. Set counter to 10
\ 3. Increment counter by 5
\ 4. Output the final value

variable counter
10 counter !
counter @ 5 + counter !

." Final counter value: " counter @ . cr