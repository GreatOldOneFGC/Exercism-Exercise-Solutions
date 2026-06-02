"""Module for determining whether a triangle is equilateral, isosceles, or scalene.
"""

def is_a_triangle(shape):
    """Function that determines if a given shape is a triangle.
    """
    def inner(sides):
        return sum(sides) > 2 * max(sides) and shape(sides)
    return inner

@is_a_triangle
def equilateral(sides):
    """Function that determines if a given triangle is equilateral.
    """
    return len(set(sides)) == 1


@is_a_triangle
def isosceles(sides):
    """Function that determines is a given triangle is isosceles.
    """
    return len(set(sides)) < 3


@is_a_triangle
def scalene(sides):
    """Function that determines is a given triangle is scalene.
    """
    return len(set(sides)) == 3