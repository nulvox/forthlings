\ Exercise 06: Comments and Formatting
\ Objective: Learn proper code documentation in Forth

\ Documentation References:
\ 1. Comments: https://www.gnu.org/software/gforth/manual/html_node/Comments.html
\ 2. Code Style: https://www.gnu.org/software/gforth/manual/html_node/Coding-Style.html

\ Instructions:
\ 1. Add appropriate comments to this code
\ 2. Format the code for readability
\ 3. Add a word description using ( ... )

\ TODO: Add comments and formatting here
: double ( n -- 2n )
  \ multiply number by 2
  2 * ;

5 double
." 5 doubled is " . cr