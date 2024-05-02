public class Solution {
    public bool IsRobotBounded(string instructions) {
     (Complex direction, Complex position) = instructions.Aggregate(
			(Direction: Complex.One, Position: Complex.Zero),
			(t, i) => i switch
			{
				'G' => (t.Direction, t.Position + t.Direction),
				'L' => (t.Direction * Complex.ImaginaryOne, t.Position),
				'R' => (t.Direction * -Complex.ImaginaryOne, t.Position)
			}
		);

		return direction != Complex.One || position == Complex.Zero;
	}

}