﻿using System.Threading;

namespace Thumbnail.Utilities {
    public static class Timer {
        public static void Sleep(int milliseconds = 0) {
            if (milliseconds < 0) {
                return;
            }

            Thread.Sleep(milliseconds);
        }
    }
}
