"""Module for determining whether a triangle is equilateral, isosceles, or scalene.
"""

def equilateral(sides):
    """Function that determines if a given triangle is equilateral.
    """
    return is_a_triangle(sides) and sides[0] == sides[1] and sides[1] == sides[2]


def isosceles(sides):
    """Function that determines is a given triangle is isosceles.
    """
    return is_a_triangle(sides) and (sides[0] == sides[1] or sides[1] == sides[2] or sides[2] == sides[0])


def scalene(sides):
    """Function that determines is a given triangle is scalene.
    """
    return is_a_triangle(sides) and sides[0] != sides[1] and sides[1] != sides[2] and sides[2] != sides[0]

def is_a_triangle(sides):
    """Function that determines if a given shape is a triangle.
    """
    if sides[0] <= 0 or sides[1] <= 0 or sides[2] <= 0:
        return False
    
    return sides[0] + sides[1] >= sides[2] and sides[1] + sides[2] >= sides[0] and sides[2] + sides[0] >= sides[1]