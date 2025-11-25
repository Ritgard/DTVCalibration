using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public static class ErrorColors
    {
        // Минимум: -0.30 — тёмно-синий
        public static readonly Color Min = Color.FromArgb(0, 64, 255);       // #0040FF ← ярко-синий

        // Промежуточные оттенки (слева от нуля)
        public static readonly Color LevelNeg25 = Color.FromArgb(0, 128, 255);     // #0080FF ← сине-голубой
        public static readonly Color LevelNeg19 = Color.FromArgb(0, 200, 255);     // #00C8FF ← светло-голубой
        public static readonly Color LevelNeg14 = Color.FromArgb(100, 255, 150);   // #64FF96 ← ярко-зелёный
        public static readonly Color LevelNeg08 = Color.FromArgb(150, 255, 150);   // #96FF96 ← свежо-зелёный

        // Центр: 0 — светло-зелёный (нейтральный, но яркий)
        public static readonly Color Mid = Color.FromArgb(200, 255, 200);           // #C8FFC8 ← очень светло-зелёный

        // Промежуточные оттенки (справа от нуля)
        public static readonly Color LevelPos08 = Color.FromArgb(255, 255, 100);   // #FFFF64 ← ярко-жёлтый
        public static readonly Color LevelPos14 = Color.FromArgb(255, 200, 50);    // #FFC832 ← оранжево-жёлтый
        public static readonly Color LevelPos19 = Color.FromArgb(255, 150, 0);     // #FF9600 ← оранжевый
        public static readonly Color LevelPos25 = Color.FromArgb(255, 80, 0);      // #FF5000 ← оранжево-красный

        // Максимум: +0.30 — ярко-красный
        public static readonly Color Max = Color.FromArgb(255, 0, 0);              // #FF0000 ← чистый красный

        /// <summary>
        /// Возвращает цвет по значению погрешности с использованием ступенчатой шкалы (11 уровней).
        /// Диапазон: от -0.30 (Min) до +0.30 (Max).
        /// Цвета — яркие и насыщенные.
        /// </summary>
        public static Color GetStepColor(double error)
        {
            if (error <= -0.30) return Min;
            if (error <= -0.25) return LevelNeg25;
            if (error <= -0.19) return LevelNeg19;
            if (error <= -0.14) return LevelNeg14;
            if (error <= -0.08) return LevelNeg08;
            if (error <= 0.03) return Mid;
            if (error <= 0.08) return LevelPos08;
            if (error <= 0.14) return LevelPos14;
            if (error <= 0.19) return LevelPos19;
            if (error <= 0.25) return LevelPos25;
            return Max;
        }

        /// <summary>
        /// Возвращает цвет по значению погрешности с использованием ПЛАВНОГО градиента
        /// (аналог Excel Color Scale, но с яркими цветами).
        /// </summary>
        public static Color GetGradientColor(double error)
        {
            const double minVal = -0.3;
            const double midVal = 0.0;
            const double maxVal = 0.3;

            if (error <= minVal) return Min;
            if (error >= maxVal) return Max;

            if (error < midVal)
            {
                double t = (error - minVal) / (midVal - minVal); // 0..1
                return Interpolate(Min, Mid, t);
            }
            else
            {
                double t = (error - midVal) / (maxVal - midVal); // 0..1
                return Interpolate(Mid, Max, t);
            }
        }

        // Вспомогательная функция для плавного перехода между двумя цветами
        private static Color Interpolate(Color c1, Color c2, double t)
        {
            t = Math.Max(0, Math.Min(1, t));
            int r = (int)(c1.R + (c2.R - c1.R) * t);
            int g = (int)(c1.G + (c2.G - c1.G) * t);
            int b = (int)(c1.B + (c2.B - c1.B) * t);
            return Color.FromArgb(r, g, b);
        }
    }
}
