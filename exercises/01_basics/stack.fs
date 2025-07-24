\ Exercise 02: Stack Operations
\ Objective: Learn basic stack manipulation

\ Documentation References:
\ 1. Stack Operations: https://www.gnu.org/software/gforth/manual/html_node/Stack-Manipulation.html
\ 2. Drop, Dup, Swap: https://www.gnu.org/software/gforth/manual/html_node/Stack-Manipulation-Words.html

\ Instructions:
\ 1. Push numbers 1, 2, 3 onto the stack
\ 2. Manipulate the stack using drop, dup, and swap
\ 3. Output the final top element

1 2 3 \ Initial stack
\ TODO: Stack manipulation here
drop \ Remove one element
dup  \ Duplicate top element
swap \ Swap top two elements

." Final top element: " . cr