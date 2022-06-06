# 12 cube problem


The task:

In this problem, we are given a set of 12 cubes with edges 1, 2, 3, ... 12. We need to divide these cubes in two groups,
so that the sum of volumes of all cubes from the 1st group is equal to the sum of volumes of all cubes from the 2nd group.
That has to be true for the sum of volumes, sum of edges, and sum of surface areas at the same time. Size of each group 
doesn't matter.

My problem solution:

I used code that compared 50000000
groups and did not find a solution. If you find a bug please let me know.

Possible solution:

I removed volume comparisons from the conditions and got an answer. It all comes down to one answer. The first group: 1, 3,
7, 8, 9, 11. The second group 2, 4, 5, 6, 10, 12. These groups have the same sum of edges, the sum of all edges of cubes,
the sum of areas.