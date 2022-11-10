namespace CellBehaviorSimulator
{
    public static class Direction
    {
        /// <summary>
        /// upper layer    middle layer    under layer
        ///   0   1          7   8           13  14
        /// 2   3   4      9  -1  10       15  16  17
        ///   5   6         11  12           18  19
        /// </summary>
        public enum DIR
        {
            /// <summary> upper left (upper layer) </summary>
            UL2 = 0,
            /// <summary> upper right (upper layer) </summary>
            UR2 = 1,
            /// <summary> left (upper layer) </summary>
            L_2 = 2,
            /// <summary> center (upper layer) </summary>
            C_2 = 3,
            /// <summary> right (upper layer) </summary>
            R_2 = 4,
            /// <summary> lower left (upper layer) </summary>
            LL2 = 5,
            /// <summary> lower right (upper layer) </summary>
            LR2 = 6,
            /// <summary> upper left (middle layer) </summary>
            UL1 = 7,
            /// <summary> upper right (middle layer) </summary>
            UR1 = 8,
            /// <summary> left (middle layer) </summary>
            L_1 = 9,
            /// <summary> center (middle layer) </summary>
            C_1 = -1,
            /// <summary> right (middle layer) </summary>
            R_1 = 10,
            /// <summary> lower left (middle layer) </summary>
            LL1 = 11,
            /// <summary> lower right (middle layer) </summary>
            LR1 = 12,
            /// <summary> upper left (underlayer) </summary>
            UL0 = 13,
            /// <summary> upper right (underlayer) </summary>
            UR0 = 14,
            /// <summary> left (underlayer) </summary>
            L_0 = 15,
            /// <summary> center (under layer) </summary>
            C_0 = 16,
            /// <summary> right (underlayer) </summary>
            R_0 = 17,
            /// <summary> lower left (underlayer) </summary>
            LL0 = 18,
            /// <summary> lower right (underlayer) </summary>
            LR0 = 19,
            /// <summary> No direction </summary>
            NULL = int.MinValue,
        }

        public static DIR GetDirection(Delta d)
        {
            if (d.DZ == 1)
            {
                if (d.DY == -1)
                {
                    if (d.DX == -1) { return DIR.UL2; }
                    else if (d.DX == 1) { return DIR.UR2; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 0)
                {
                    if (d.DX == -2) { return DIR.L_2; }
                    else if (d.DX == 0) { return DIR.C_2; }
                    else if (d.DX == 2) { return DIR.R_2; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 1)
                {
                    if (d.DX == -1) { return DIR.LL2; }
                    else if (d.DX == 1) { return DIR.LR2; }
                    else { return DIR.NULL; }
                }
                else { return DIR.NULL; }
            }
            else if (d.DZ == 0)
            {
                if (d.DY == -1)
                {
                    if (d.DX == -1) { return DIR.UL1; }
                    else if (d.DX == 1) { return DIR.UR1; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 0)
                {
                    if (d.DX == -2) { return DIR.L_1; }
                    else if (d.DX == 0) { return DIR.C_1; }
                    else if (d.DX == 2) { return DIR.R_1; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 1)
                {
                    if (d.DX == -1) { return DIR.LL1; }
                    else if (d.DX == 1) { return DIR.LR1; }
                    else { return DIR.NULL; }
                }
                else { return DIR.NULL; }
            }
            else if (d.DZ == -1)
            {
                if (d.DY == -1)
                {
                    if (d.DX == -1) { return DIR.UL0; }
                    else if (d.DX == 1) { return DIR.UR0; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 0)
                {
                    if (d.DX == -2) { return DIR.L_0; }
                    else if (d.DX == 0) { return DIR.C_0; }
                    else if (d.DX == 2) { return DIR.R_0; }
                    else { return DIR.NULL; }
                }
                else if (d.DY == 1)
                {
                    if (d.DX == -1) { return DIR.LL0; }
                    else if (d.DX == 1) { return DIR.LR0; }
                    else { return DIR.NULL; }
                }
                else { return DIR.NULL; }
            }
            else { return DIR.NULL; }
        }
    }
}
