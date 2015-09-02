﻿using UnityEngine;
using NetworkExtensions.Framework;

namespace NetworkExtensions.NewNetwork.OneWay4L.Meshes
{
    public partial class OneWay4LMeshes
    {
        public static MeshData GetGroundTransitionData()
        {
            Vector3[] vertices = new Vector3[] {
                new Vector3 (-12.00000f, 0.00000f, -32.00000f),
                new Vector3 (12.00000f, 0.00000f, -32.00000f),
                new Vector3 (8.00000f, -0.00000f, -32.00000f),
                new Vector3 (8.00000f, 0.00000f, 32.00000f),
                new Vector3 (-8.00000f, 0.00000f, 32.00000f),
                new Vector3 (-8.00000f, -0.00000f, -32.00000f),
                new Vector3 (12.00000f, 0.00000f, 32.00000f),
                new Vector3 (-12.00000f, 0.00000f, 32.00000f),
                new Vector3 (12.50000f, -1.05500f, 32.00000f),
                new Vector3 (-12.50000f, -1.05500f, 32.00000f),
                new Vector3 (12.50000f, -1.05500f, -32.00000f),
                new Vector3 (-12.50000f, -1.05500f, -32.00000f),
                new Vector3 (8.00000f, -0.30000f, -32.00000f),
                new Vector3 (8.00000f, -0.30000f, 32.00000f),
                new Vector3 (-8.00000f, -0.30000f, 32.00000f),
                new Vector3 (-8.00000f, -0.30000f, -32.00000f),
                new Vector3 (0.00000f, -0.30000f, -32.00000f),
                new Vector3 (0.00000f, -0.30000f, 32.00000f),
                new Vector3 (8.00000f, -0.00000f, -29.33333f),
                new Vector3 (8.00000f, 0.00000f, -26.66667f),
                new Vector3 (8.00000f, 0.00000f, -24.00000f),
                new Vector3 (8.00000f, 0.00000f, -21.33333f),
                new Vector3 (8.00000f, 0.00000f, -18.66667f),
                new Vector3 (8.00000f, 0.00000f, -16.00000f),
                new Vector3 (8.00000f, 0.00000f, -13.33333f),
                new Vector3 (8.00000f, 0.00000f, -10.66667f),
                new Vector3 (8.00000f, 0.00000f, -8.00000f),
                new Vector3 (8.00000f, 0.00000f, -5.33333f),
                new Vector3 (8.00000f, 0.00000f, -2.66667f),
                new Vector3 (8.00000f, 0.00000f, -0.00000f),
                new Vector3 (8.00000f, 0.00000f, 2.66666f),
                new Vector3 (8.00000f, 0.00000f, 5.33334f),
                new Vector3 (8.00000f, 0.00000f, 8.00000f),
                new Vector3 (8.00000f, 0.00000f, 10.66666f),
                new Vector3 (8.00000f, 0.00000f, 13.33334f),
                new Vector3 (8.00000f, 0.00000f, 16.00000f),
                new Vector3 (8.00000f, 0.00000f, 18.66666f),
                new Vector3 (8.00000f, 0.00000f, 21.33334f),
                new Vector3 (8.00000f, 0.00000f, 24.00000f),
                new Vector3 (8.00000f, 0.00000f, 26.66666f),
                new Vector3 (8.00000f, 0.00000f, 29.33334f),
                new Vector3 (12.00000f, 0.00000f, 29.33333f),
                new Vector3 (12.00000f, 0.00000f, 26.66667f),
                new Vector3 (12.00000f, 0.00000f, 24.00000f),
                new Vector3 (12.00000f, 0.00000f, 21.33333f),
                new Vector3 (12.00000f, 0.00000f, 18.66667f),
                new Vector3 (12.00000f, 0.00000f, 16.00000f),
                new Vector3 (12.00000f, 0.00000f, 13.33333f),
                new Vector3 (12.00000f, 0.00000f, 10.66667f),
                new Vector3 (12.00000f, 0.00000f, 8.00000f),
                new Vector3 (12.00000f, 0.00000f, 5.33333f),
                new Vector3 (12.00000f, 0.00000f, 2.66667f),
                new Vector3 (12.00000f, 0.00000f, -0.00000f),
                new Vector3 (12.00000f, 0.00000f, -2.66666f),
                new Vector3 (12.00000f, 0.00000f, -5.33334f),
                new Vector3 (12.00000f, 0.00000f, -8.00000f),
                new Vector3 (12.00000f, 0.00000f, -10.66666f),
                new Vector3 (12.00000f, 0.00000f, -13.33334f),
                new Vector3 (12.00000f, 0.00000f, -16.00000f),
                new Vector3 (12.00000f, 0.00000f, -18.66666f),
                new Vector3 (12.00000f, 0.00000f, -21.33334f),
                new Vector3 (12.00000f, 0.00000f, -24.00000f),
                new Vector3 (12.00000f, 0.00000f, -26.66666f),
                new Vector3 (12.00000f, 0.00000f, -29.33334f),
                new Vector3 (-12.00000f, 0.00000f, -29.33333f),
                new Vector3 (-12.00000f, 0.00000f, -26.66667f),
                new Vector3 (-12.00000f, 0.00000f, -24.00000f),
                new Vector3 (-12.00000f, 0.00000f, -21.33333f),
                new Vector3 (-12.00000f, 0.00000f, -18.66667f),
                new Vector3 (-12.00000f, 0.00000f, -16.00000f),
                new Vector3 (-12.00000f, 0.00000f, -13.33333f),
                new Vector3 (-12.00000f, 0.00000f, -10.66667f),
                new Vector3 (-12.00000f, 0.00000f, -8.00000f),
                new Vector3 (-12.00000f, 0.00000f, -5.33333f),
                new Vector3 (-12.00000f, 0.00000f, -2.66667f),
                new Vector3 (-12.00000f, 0.00000f, -0.00000f),
                new Vector3 (-12.00000f, 0.00000f, 2.66666f),
                new Vector3 (-12.00000f, 0.00000f, 5.33334f),
                new Vector3 (-12.00000f, 0.00000f, 8.00000f),
                new Vector3 (-12.00000f, 0.00000f, 10.66666f),
                new Vector3 (-12.00000f, 0.00000f, 13.33334f),
                new Vector3 (-12.00000f, 0.00000f, 16.00000f),
                new Vector3 (-12.00000f, 0.00000f, 18.66666f),
                new Vector3 (-12.00000f, 0.00000f, 21.33334f),
                new Vector3 (-12.00000f, 0.00000f, 24.00000f),
                new Vector3 (-12.00000f, 0.00000f, 26.66666f),
                new Vector3 (-12.00000f, 0.00000f, 29.33334f),
                new Vector3 (-8.00000f, 0.00000f, 29.33333f),
                new Vector3 (-8.00000f, 0.00000f, 26.66667f),
                new Vector3 (-8.00000f, 0.00000f, 24.00000f),
                new Vector3 (-8.00000f, 0.00000f, 21.33333f),
                new Vector3 (-8.00000f, 0.00000f, 18.66667f),
                new Vector3 (-8.00000f, 0.00000f, 16.00000f),
                new Vector3 (-8.00000f, 0.00000f, 13.33333f),
                new Vector3 (-8.00000f, 0.00000f, 10.66667f),
                new Vector3 (-8.00000f, 0.00000f, 8.00000f),
                new Vector3 (-8.00000f, 0.00000f, 5.33333f),
                new Vector3 (-8.00000f, 0.00000f, 2.66667f),
                new Vector3 (-8.00000f, 0.00000f, -0.00000f),
                new Vector3 (-8.00000f, 0.00000f, -2.66666f),
                new Vector3 (-8.00000f, 0.00000f, -5.33334f),
                new Vector3 (-8.00000f, 0.00000f, -8.00000f),
                new Vector3 (-8.00000f, 0.00000f, -10.66666f),
                new Vector3 (-8.00000f, 0.00000f, -13.33334f),
                new Vector3 (-8.00000f, 0.00000f, -16.00000f),
                new Vector3 (-8.00000f, 0.00000f, -18.66666f),
                new Vector3 (-8.00000f, 0.00000f, -21.33334f),
                new Vector3 (-8.00000f, 0.00000f, -24.00000f),
                new Vector3 (-8.00000f, 0.00000f, -26.66666f),
                new Vector3 (-8.00000f, -0.00000f, -29.33334f),
                new Vector3 (0.00000f, -0.30000f, 29.33333f),
                new Vector3 (0.00000f, -0.30000f, 26.66667f),
                new Vector3 (0.00000f, -0.30000f, 24.00000f),
                new Vector3 (0.00000f, -0.30000f, 21.33333f),
                new Vector3 (0.00000f, -0.30000f, 18.66667f),
                new Vector3 (0.00000f, -0.30000f, 16.00000f),
                new Vector3 (0.00000f, -0.30000f, 13.33333f),
                new Vector3 (0.00000f, -0.30000f, 10.66667f),
                new Vector3 (0.00000f, -0.30000f, 8.00000f),
                new Vector3 (0.00000f, -0.30000f, 5.33333f),
                new Vector3 (0.00000f, -0.30000f, 2.66667f),
                new Vector3 (0.00000f, -0.30000f, -0.00000f),
                new Vector3 (0.00000f, -0.30000f, -2.66666f),
                new Vector3 (0.00000f, -0.30000f, -5.33334f),
                new Vector3 (0.00000f, -0.30000f, -8.00000f),
                new Vector3 (0.00000f, -0.30000f, -10.66666f),
                new Vector3 (0.00000f, -0.30000f, -13.33334f),
                new Vector3 (0.00000f, -0.30000f, -16.00000f),
                new Vector3 (0.00000f, -0.30000f, -18.66666f),
                new Vector3 (0.00000f, -0.30000f, -21.33334f),
                new Vector3 (0.00000f, -0.30000f, -24.00000f),
                new Vector3 (0.00000f, -0.30000f, -26.66666f),
                new Vector3 (0.00000f, -0.30000f, -29.33334f),
                new Vector3 (-8.00000f, -0.30000f, -29.33333f),
                new Vector3 (-8.00000f, -0.30000f, -26.66667f),
                new Vector3 (-8.00000f, -0.30000f, -24.00000f),
                new Vector3 (-8.00000f, -0.30000f, -21.33333f),
                new Vector3 (-8.00000f, -0.30000f, -18.66667f),
                new Vector3 (-8.00000f, -0.30000f, -16.00000f),
                new Vector3 (-8.00000f, -0.30000f, -13.33333f),
                new Vector3 (-8.00000f, -0.30000f, -10.66667f),
                new Vector3 (-8.00000f, -0.30000f, -8.00000f),
                new Vector3 (-8.00000f, -0.30000f, -5.33333f),
                new Vector3 (-8.00000f, -0.30000f, -2.66667f),
                new Vector3 (-8.00000f, -0.30000f, -0.00000f),
                new Vector3 (-8.00000f, -0.30000f, 2.66666f),
                new Vector3 (-8.00000f, -0.30000f, 5.33334f),
                new Vector3 (-8.00000f, -0.30000f, 8.00000f),
                new Vector3 (-8.00000f, -0.30000f, 10.66666f),
                new Vector3 (-8.00000f, -0.30000f, 13.33334f),
                new Vector3 (-8.00000f, -0.30000f, 16.00000f),
                new Vector3 (-8.00000f, -0.30000f, 18.66666f),
                new Vector3 (-8.00000f, -0.30000f, 21.33334f),
                new Vector3 (-8.00000f, -0.30000f, 24.00000f),
                new Vector3 (-8.00000f, -0.30000f, 26.66666f),
                new Vector3 (-8.00000f, -0.30000f, 29.33334f),
                new Vector3 (8.00000f, -0.30000f, 29.33333f),
                new Vector3 (8.00000f, -0.30000f, 26.66667f),
                new Vector3 (8.00000f, -0.30000f, 24.00000f),
                new Vector3 (8.00000f, -0.30000f, 21.33333f),
                new Vector3 (8.00000f, -0.30000f, 18.66667f),
                new Vector3 (8.00000f, -0.30000f, 16.00000f),
                new Vector3 (8.00000f, -0.30000f, 13.33333f),
                new Vector3 (8.00000f, -0.30000f, 10.66667f),
                new Vector3 (8.00000f, -0.30000f, 8.00000f),
                new Vector3 (8.00000f, -0.30000f, 5.33333f),
                new Vector3 (8.00000f, -0.30000f, 2.66667f),
                new Vector3 (8.00000f, -0.30000f, -0.00000f),
                new Vector3 (8.00000f, -0.30000f, -2.66666f),
                new Vector3 (8.00000f, -0.30000f, -5.33334f),
                new Vector3 (8.00000f, -0.30000f, -8.00000f),
                new Vector3 (8.00000f, -0.30000f, -10.66666f),
                new Vector3 (8.00000f, -0.30000f, -13.33334f),
                new Vector3 (8.00000f, -0.30000f, -16.00000f),
                new Vector3 (8.00000f, -0.30000f, -18.66666f),
                new Vector3 (8.00000f, -0.30000f, -21.33334f),
                new Vector3 (8.00000f, -0.30000f, -24.00000f),
                new Vector3 (8.00000f, -0.30000f, -26.66666f),
                new Vector3 (8.00000f, -0.30000f, -29.33334f),
                new Vector3 (12.50000f, -1.05500f, 29.33333f),
                new Vector3 (12.50000f, -1.05500f, 26.66667f),
                new Vector3 (12.50000f, -1.05500f, 24.00000f),
                new Vector3 (12.50000f, -1.05500f, 21.33333f),
                new Vector3 (12.50000f, -1.05500f, 18.66667f),
                new Vector3 (12.50000f, -1.05500f, 16.00000f),
                new Vector3 (12.50000f, -1.05500f, 13.33333f),
                new Vector3 (12.50000f, -1.05500f, 10.66667f),
                new Vector3 (12.50000f, -1.05500f, 8.00000f),
                new Vector3 (12.50000f, -1.05500f, 5.33333f),
                new Vector3 (12.50000f, -1.05500f, 2.66667f),
                new Vector3 (12.50000f, -1.05500f, -0.00000f),
                new Vector3 (12.50000f, -1.05500f, -2.66666f),
                new Vector3 (12.50000f, -1.05500f, -5.33334f),
                new Vector3 (12.50000f, -1.05500f, -8.00000f),
                new Vector3 (12.50000f, -1.05500f, -10.66666f),
                new Vector3 (12.50000f, -1.05500f, -13.33334f),
                new Vector3 (12.50000f, -1.05500f, -16.00000f),
                new Vector3 (12.50000f, -1.05500f, -18.66666f),
                new Vector3 (12.50000f, -1.05500f, -21.33334f),
                new Vector3 (12.50000f, -1.05500f, -24.00000f),
                new Vector3 (12.50000f, -1.05500f, -26.66666f),
                new Vector3 (12.50000f, -1.05500f, -29.33334f),
                new Vector3 (-12.50000f, -1.05500f, -29.33333f),
                new Vector3 (-12.50000f, -1.05500f, -26.66667f),
                new Vector3 (-12.50000f, -1.05500f, -24.00000f),
                new Vector3 (-12.50000f, -1.05500f, -21.33333f),
                new Vector3 (-12.50000f, -1.05500f, -18.66667f),
                new Vector3 (-12.50000f, -1.05500f, -16.00000f),
                new Vector3 (-12.50000f, -1.05500f, -13.33333f),
                new Vector3 (-12.50000f, -1.05500f, -10.66667f),
                new Vector3 (-12.50000f, -1.05500f, -8.00000f),
                new Vector3 (-12.50000f, -1.05500f, -5.33333f),
                new Vector3 (-12.50000f, -1.05500f, -2.66667f),
                new Vector3 (-12.50000f, -1.05500f, -0.00000f),
                new Vector3 (-12.50000f, -1.05500f, 2.66666f),
                new Vector3 (-12.50000f, -1.05500f, 5.33334f),
                new Vector3 (-12.50000f, -1.05500f, 8.00000f),
                new Vector3 (-12.50000f, -1.05500f, 10.66666f),
                new Vector3 (-12.50000f, -1.05500f, 13.33334f),
                new Vector3 (-12.50000f, -1.05500f, 16.00000f),
                new Vector3 (-12.50000f, -1.05500f, 18.66666f),
                new Vector3 (-12.50000f, -1.05500f, 21.33334f),
                new Vector3 (-12.50000f, -1.05500f, 24.00000f),
                new Vector3 (-12.50000f, -1.05500f, 26.66666f),
                new Vector3 (-12.50000f, -1.05500f, 29.33334f)
            };

            int[] triangles = new int[] {
                29, 52, 53,
                53, 28, 29,
                75, 98, 99,
                99, 74, 75,
                121, 144, 145,
                145, 120, 121,
                121, 167, 168,
                168, 122, 121,
                190, 52, 51,
                51, 189, 190,
                75, 213, 214,
                214, 76, 75,
                29, 167, 166,
                166, 30, 29,
                98, 144, 143,
                143, 99, 98,
                3, 6, 41,
                41, 40, 3,
                40, 41, 42,
                42, 39, 40,
                39, 42, 43,
                43, 38, 39,
                38, 43, 44,
                44, 37, 38,
                37, 44, 45,
                45, 36, 37,
                36, 45, 46,
                46, 35, 36,
                35, 46, 47,
                47, 34, 35,
                34, 47, 48,
                48, 33, 34,
                33, 48, 49,
                49, 32, 33,
                32, 49, 50,
                50, 31, 32,
                31, 50, 51,
                51, 30, 31,
                30, 51, 52,
                52, 29, 30,
                1, 2, 18,
                18, 63, 1,
                63, 18, 19,
                19, 62, 63,
                62, 19, 20,
                20, 61, 62,
                61, 20, 21,
                21, 60, 61,
                60, 21, 22,
                22, 59, 60,
                59, 22, 23,
                23, 58, 59,
                58, 23, 24,
                24, 57, 58,
                57, 24, 25,
                25, 56, 57,
                56, 25, 26,
                26, 55, 56,
                55, 26, 27,
                27, 54, 55,
                54, 27, 28,
                28, 53, 54,
                7, 4, 87,
                87, 86, 7,
                86, 87, 88,
                88, 85, 86,
                85, 88, 89,
                89, 84, 85,
                84, 89, 90,
                90, 83, 84,
                83, 90, 91,
                91, 82, 83,
                82, 91, 92,
                92, 81, 82,
                81, 92, 93,
                93, 80, 81,
                80, 93, 94,
                94, 79, 80,
                79, 94, 95,
                95, 78, 79,
                78, 95, 96,
                96, 77, 78,
                77, 96, 97,
                97, 76, 77,
                76, 97, 98,
                98, 75, 76,
                5, 0, 64,
                64, 109, 5,
                109, 64, 65,
                65, 108, 109,
                108, 65, 66,
                66, 107, 108,
                107, 66, 67,
                67, 106, 107,
                106, 67, 68,
                68, 105, 106,
                105, 68, 69,
                69, 104, 105,
                104, 69, 70,
                70, 103, 104,
                103, 70, 71,
                71, 102, 103,
                102, 71, 72,
                72, 101, 102,
                101, 72, 73,
                73, 100, 101,
                100, 73, 74,
                74, 99, 100,
                16, 15, 133,
                133, 132, 16,
                132, 133, 134,
                134, 131, 132,
                131, 134, 135,
                135, 130, 131,
                130, 135, 136,
                136, 129, 130,
                129, 136, 137,
                137, 128, 129,
                128, 137, 138,
                138, 127, 128,
                127, 138, 139,
                139, 126, 127,
                126, 139, 140,
                140, 125, 126,
                125, 140, 141,
                141, 124, 125,
                124, 141, 142,
                142, 123, 124,
                123, 142, 143,
                143, 122, 123,
                122, 143, 144,
                144, 121, 122,
                14, 17, 110,
                110, 155, 14,
                155, 110, 111,
                111, 154, 155,
                154, 111, 112,
                112, 153, 154,
                153, 112, 113,
                113, 152, 153,
                152, 113, 114,
                114, 151, 152,
                151, 114, 115,
                115, 150, 151,
                150, 115, 116,
                116, 149, 150,
                149, 116, 117,
                117, 148, 149,
                148, 117, 118,
                118, 147, 148,
                147, 118, 119,
                119, 146, 147,
                146, 119, 120,
                120, 145, 146,
                17, 13, 156,
                156, 110, 17,
                110, 156, 157,
                157, 111, 110,
                111, 157, 158,
                158, 112, 111,
                112, 158, 159,
                159, 113, 112,
                113, 159, 160,
                160, 114, 113,
                114, 160, 161,
                161, 115, 114,
                115, 161, 162,
                162, 116, 115,
                116, 162, 163,
                163, 117, 116,
                117, 163, 164,
                164, 118, 117,
                118, 164, 165,
                165, 119, 118,
                119, 165, 166,
                166, 120, 119,
                120, 166, 167,
                167, 121, 120,
                12, 16, 132,
                132, 178, 12,
                178, 132, 131,
                131, 177, 178,
                177, 131, 130,
                130, 176, 177,
                176, 130, 129,
                129, 175, 176,
                175, 129, 128,
                128, 174, 175,
                174, 128, 127,
                127, 173, 174,
                173, 127, 126,
                126, 172, 173,
                172, 126, 125,
                125, 171, 172,
                171, 125, 124,
                124, 170, 171,
                170, 124, 123,
                123, 169, 170,
                169, 123, 122,
                122, 168, 169,
                10, 1, 63,
                63, 201, 10,
                201, 63, 62,
                62, 200, 201,
                200, 62, 61,
                61, 199, 200,
                199, 61, 60,
                60, 198, 199,
                198, 60, 59,
                59, 197, 198,
                197, 59, 58,
                58, 196, 197,
                196, 58, 57,
                57, 195, 196,
                195, 57, 56,
                56, 194, 195,
                194, 56, 55,
                55, 193, 194,
                193, 55, 54,
                54, 192, 193,
                192, 54, 53,
                53, 191, 192,
                191, 53, 52,
                52, 190, 191,
                6, 8, 179,
                179, 41, 6,
                41, 179, 180,
                180, 42, 41,
                42, 180, 181,
                181, 43, 42,
                43, 181, 182,
                182, 44, 43,
                44, 182, 183,
                183, 45, 44,
                45, 183, 184,
                184, 46, 45,
                46, 184, 185,
                185, 47, 46,
                47, 185, 186,
                186, 48, 47,
                48, 186, 187,
                187, 49, 48,
                49, 187, 188,
                188, 50, 49,
                50, 188, 189,
                189, 51, 50,
                0, 11, 202,
                202, 64, 0,
                64, 202, 203,
                203, 65, 64,
                65, 203, 204,
                204, 66, 65,
                66, 204, 205,
                205, 67, 66,
                67, 205, 206,
                206, 68, 67,
                68, 206, 207,
                207, 69, 68,
                69, 207, 208,
                208, 70, 69,
                70, 208, 209,
                209, 71, 70,
                71, 209, 210,
                210, 72, 71,
                72, 210, 211,
                211, 73, 72,
                73, 211, 212,
                212, 74, 73,
                74, 212, 213,
                213, 75, 74,
                9, 7, 86,
                86, 224, 9,
                224, 86, 85,
                85, 223, 224,
                223, 85, 84,
                84, 222, 223,
                222, 84, 83,
                83, 221, 222,
                221, 83, 82,
                82, 220, 221,
                220, 82, 81,
                81, 219, 220,
                219, 81, 80,
                80, 218, 219,
                218, 80, 79,
                79, 217, 218,
                217, 79, 78,
                78, 216, 217,
                216, 78, 77,
                77, 215, 216,
                215, 77, 76,
                76, 214, 215,
                2, 12, 178,
                178, 18, 2,
                18, 178, 177,
                177, 19, 18,
                19, 177, 176,
                176, 20, 19,
                20, 176, 175,
                175, 21, 20,
                21, 175, 174,
                174, 22, 21,
                22, 174, 173,
                173, 23, 22,
                23, 173, 172,
                172, 24, 23,
                24, 172, 171,
                171, 25, 24,
                25, 171, 170,
                170, 26, 25,
                26, 170, 169,
                169, 27, 26,
                27, 169, 168,
                168, 28, 27,
                28, 168, 167,
                167, 29, 28,
                13, 3, 40,
                40, 156, 13,
                156, 40, 39,
                39, 157, 156,
                157, 39, 38,
                38, 158, 157,
                158, 38, 37,
                37, 159, 158,
                159, 37, 36,
                36, 160, 159,
                160, 36, 35,
                35, 161, 160,
                161, 35, 34,
                34, 162, 161,
                162, 34, 33,
                33, 163, 162,
                163, 33, 32,
                32, 164, 163,
                164, 32, 31,
                31, 165, 164,
                165, 31, 30,
                30, 166, 165,
                4, 14, 155,
                155, 87, 4,
                87, 155, 154,
                154, 88, 87,
                88, 154, 153,
                153, 89, 88,
                89, 153, 152,
                152, 90, 89,
                90, 152, 151,
                151, 91, 90,
                91, 151, 150,
                150, 92, 91,
                92, 150, 149,
                149, 93, 92,
                93, 149, 148,
                148, 94, 93,
                94, 148, 147,
                147, 95, 94,
                95, 147, 146,
                146, 96, 95,
                96, 146, 145,
                145, 97, 96,
                97, 145, 144,
                144, 98, 97,
                15, 5, 109,
                109, 133, 15,
                133, 109, 108,
                108, 134, 133,
                134, 108, 107,
                107, 135, 134,
                135, 107, 106,
                106, 136, 135,
                136, 106, 105,
                105, 137, 136,
                137, 105, 104,
                104, 138, 137,
                138, 104, 103,
                103, 139, 138,
                139, 103, 102,
                102, 140, 139,
                140, 102, 101,
                101, 141, 140,
                141, 101, 100,
                100, 142, 141,
                142, 100, 99,
                99, 143, 142
            };

            Vector2[] uv = new Vector2[] {
                new Vector2 (0.02f, 0f),
                new Vector2 (0.98f, 0f),
                new Vector2 (0.82f, 0f),
                new Vector2 (0.82f, 1f),
                new Vector2 (0.18f, 1f),
                new Vector2 (0.18f, 0f),
                new Vector2 (0.98f, 1f),
                new Vector2 (0.02f, 1f),
                new Vector2 (1f, 1f),
                new Vector2 (0f, 1f),
                new Vector2 (1f, 0f),
                new Vector2 (0f, 0f),
                new Vector2 (0.82f, 0f),
                new Vector2 (0.82f, 1f),
                new Vector2 (0.18f, 1f),
                new Vector2 (0.18f, 0f),
                new Vector2 (0.5f, 0f),
                new Vector2 (0.5f, 1f),
                new Vector2 (0.82f, 0.0417f),
                new Vector2 (0.82f, 0.0833f),
                new Vector2 (0.82f, 0.125f),
                new Vector2 (0.82f, 0.1667f),
                new Vector2 (0.82f, 0.2083f),
                new Vector2 (0.82f, 0.25f),
                new Vector2 (0.82f, 0.2917f),
                new Vector2 (0.82f, 0.3333f),
                new Vector2 (0.82f, 0.375f),
                new Vector2 (0.82f, 0.4167f),
                new Vector2 (0.82f, 0.4583f),
                new Vector2 (0.82f, 0.5f),
                new Vector2 (0.82f, 0.5417f),
                new Vector2 (0.82f, 0.5833f),
                new Vector2 (0.82f, 0.625f),
                new Vector2 (0.82f, 0.6667f),
                new Vector2 (0.82f, 0.7083f),
                new Vector2 (0.82f, 0.75f),
                new Vector2 (0.82f, 0.7917f),
                new Vector2 (0.82f, 0.8333f),
                new Vector2 (0.82f, 0.875f),
                new Vector2 (0.82f, 0.9167f),
                new Vector2 (0.82f, 0.9583f),
                new Vector2 (0.98f, 0.9583f),
                new Vector2 (0.98f, 0.9167f),
                new Vector2 (0.98f, 0.875f),
                new Vector2 (0.98f, 0.8333f),
                new Vector2 (0.98f, 0.7917f),
                new Vector2 (0.98f, 0.75f),
                new Vector2 (0.98f, 0.7083f),
                new Vector2 (0.98f, 0.6667f),
                new Vector2 (0.98f, 0.625f),
                new Vector2 (0.98f, 0.5833f),
                new Vector2 (0.98f, 0.5417f),
                new Vector2 (0.98f, 0.5f),
                new Vector2 (0.98f, 0.4583f),
                new Vector2 (0.98f, 0.4167f),
                new Vector2 (0.98f, 0.375f),
                new Vector2 (0.98f, 0.3333f),
                new Vector2 (0.98f, 0.2917f),
                new Vector2 (0.98f, 0.25f),
                new Vector2 (0.98f, 0.2083f),
                new Vector2 (0.98f, 0.1667f),
                new Vector2 (0.98f, 0.125f),
                new Vector2 (0.98f, 0.0833f),
                new Vector2 (0.98f, 0.0417f),
                new Vector2 (0.02f, 0.0417f),
                new Vector2 (0.02f, 0.0833f),
                new Vector2 (0.02f, 0.125f),
                new Vector2 (0.02f, 0.1667f),
                new Vector2 (0.02f, 0.2083f),
                new Vector2 (0.02f, 0.25f),
                new Vector2 (0.02f, 0.2917f),
                new Vector2 (0.02f, 0.3333f),
                new Vector2 (0.02f, 0.375f),
                new Vector2 (0.02f, 0.4167f),
                new Vector2 (0.02f, 0.4583f),
                new Vector2 (0.02f, 0.5f),
                new Vector2 (0.02f, 0.5417f),
                new Vector2 (0.02f, 0.5833f),
                new Vector2 (0.02f, 0.625f),
                new Vector2 (0.02f, 0.6667f),
                new Vector2 (0.02f, 0.7083f),
                new Vector2 (0.02f, 0.75f),
                new Vector2 (0.02f, 0.7917f),
                new Vector2 (0.02f, 0.8333f),
                new Vector2 (0.02f, 0.875f),
                new Vector2 (0.02f, 0.9167f),
                new Vector2 (0.02f, 0.9583f),
                new Vector2 (0.18f, 0.9583f),
                new Vector2 (0.18f, 0.9167f),
                new Vector2 (0.18f, 0.875f),
                new Vector2 (0.18f, 0.8333f),
                new Vector2 (0.18f, 0.7917f),
                new Vector2 (0.18f, 0.75f),
                new Vector2 (0.18f, 0.7083f),
                new Vector2 (0.18f, 0.6667f),
                new Vector2 (0.18f, 0.625f),
                new Vector2 (0.18f, 0.5833f),
                new Vector2 (0.18f, 0.5417f),
                new Vector2 (0.18f, 0.5f),
                new Vector2 (0.18f, 0.4583f),
                new Vector2 (0.18f, 0.4167f),
                new Vector2 (0.18f, 0.375f),
                new Vector2 (0.18f, 0.3333f),
                new Vector2 (0.18f, 0.2917f),
                new Vector2 (0.18f, 0.25f),
                new Vector2 (0.18f, 0.2083f),
                new Vector2 (0.18f, 0.1667f),
                new Vector2 (0.18f, 0.125f),
                new Vector2 (0.18f, 0.0833f),
                new Vector2 (0.18f, 0.0417f),
                new Vector2 (0.5f, 0.9583f),
                new Vector2 (0.5f, 0.9167f),
                new Vector2 (0.5f, 0.875f),
                new Vector2 (0.5f, 0.8333f),
                new Vector2 (0.5f, 0.7917f),
                new Vector2 (0.5f, 0.75f),
                new Vector2 (0.5f, 0.7083f),
                new Vector2 (0.5f, 0.6667f),
                new Vector2 (0.5f, 0.625f),
                new Vector2 (0.5f, 0.5833f),
                new Vector2 (0.5f, 0.5417f),
                new Vector2 (0.5f, 0.5f),
                new Vector2 (0.5f, 0.4583f),
                new Vector2 (0.5f, 0.4167f),
                new Vector2 (0.5f, 0.375f),
                new Vector2 (0.5f, 0.3333f),
                new Vector2 (0.5f, 0.2917f),
                new Vector2 (0.5f, 0.25f),
                new Vector2 (0.5f, 0.2083f),
                new Vector2 (0.5f, 0.1667f),
                new Vector2 (0.5f, 0.125f),
                new Vector2 (0.5f, 0.0833f),
                new Vector2 (0.5f, 0.0417f),
                new Vector2 (0.18f, 0.0417f),
                new Vector2 (0.18f, 0.0833f),
                new Vector2 (0.18f, 0.125f),
                new Vector2 (0.18f, 0.1667f),
                new Vector2 (0.18f, 0.2083f),
                new Vector2 (0.18f, 0.25f),
                new Vector2 (0.18f, 0.2917f),
                new Vector2 (0.18f, 0.3333f),
                new Vector2 (0.18f, 0.375f),
                new Vector2 (0.18f, 0.4167f),
                new Vector2 (0.18f, 0.4583f),
                new Vector2 (0.18f, 0.5f),
                new Vector2 (0.18f, 0.5417f),
                new Vector2 (0.18f, 0.5833f),
                new Vector2 (0.18f, 0.625f),
                new Vector2 (0.18f, 0.6667f),
                new Vector2 (0.18f, 0.7083f),
                new Vector2 (0.18f, 0.75f),
                new Vector2 (0.18f, 0.7917f),
                new Vector2 (0.18f, 0.8333f),
                new Vector2 (0.18f, 0.875f),
                new Vector2 (0.18f, 0.9167f),
                new Vector2 (0.18f, 0.9583f),
                new Vector2 (0.82f, 0.9583f),
                new Vector2 (0.82f, 0.9167f),
                new Vector2 (0.82f, 0.875f),
                new Vector2 (0.82f, 0.8333f),
                new Vector2 (0.82f, 0.7917f),
                new Vector2 (0.82f, 0.75f),
                new Vector2 (0.82f, 0.7083f),
                new Vector2 (0.82f, 0.6667f),
                new Vector2 (0.82f, 0.625f),
                new Vector2 (0.82f, 0.5833f),
                new Vector2 (0.82f, 0.5417f),
                new Vector2 (0.82f, 0.5f),
                new Vector2 (0.82f, 0.4583f),
                new Vector2 (0.82f, 0.4167f),
                new Vector2 (0.82f, 0.375f),
                new Vector2 (0.82f, 0.3333f),
                new Vector2 (0.82f, 0.2917f),
                new Vector2 (0.82f, 0.25f),
                new Vector2 (0.82f, 0.2083f),
                new Vector2 (0.82f, 0.1667f),
                new Vector2 (0.82f, 0.125f),
                new Vector2 (0.82f, 0.0833f),
                new Vector2 (0.82f, 0.0417f),
                new Vector2 (1f, 0.9583f),
                new Vector2 (1f, 0.9167f),
                new Vector2 (1f, 0.875f),
                new Vector2 (1f, 0.8333f),
                new Vector2 (1f, 0.7917f),
                new Vector2 (1f, 0.75f),
                new Vector2 (1f, 0.7083f),
                new Vector2 (1f, 0.6667f),
                new Vector2 (1f, 0.625f),
                new Vector2 (1f, 0.5833f),
                new Vector2 (1f, 0.5417f),
                new Vector2 (1f, 0.5f),
                new Vector2 (1f, 0.4583f),
                new Vector2 (1f, 0.4167f),
                new Vector2 (1f, 0.375f),
                new Vector2 (1f, 0.3333f),
                new Vector2 (1f, 0.2917f),
                new Vector2 (1f, 0.25f),
                new Vector2 (1f, 0.2083f),
                new Vector2 (1f, 0.1667f),
                new Vector2 (1f, 0.125f),
                new Vector2 (1f, 0.0833f),
                new Vector2 (1f, 0.0417f),
                new Vector2 (0f, 0.0417f),
                new Vector2 (0f, 0.0833f),
                new Vector2 (0f, 0.125f),
                new Vector2 (0f, 0.1667f),
                new Vector2 (0f, 0.2083f),
                new Vector2 (0f, 0.25f),
                new Vector2 (0f, 0.2917f),
                new Vector2 (0f, 0.3333f),
                new Vector2 (0f, 0.375f),
                new Vector2 (0f, 0.4167f),
                new Vector2 (0f, 0.4583f),
                new Vector2 (0f, 0.5f),
                new Vector2 (0f, 0.5417f),
                new Vector2 (0f, 0.5833f),
                new Vector2 (0f, 0.625f),
                new Vector2 (0f, 0.6667f),
                new Vector2 (0f, 0.7083f),
                new Vector2 (0f, 0.75f),
                new Vector2 (0f, 0.7917f),
                new Vector2 (0f, 0.8333f),
                new Vector2 (0f, 0.875f),
                new Vector2 (0f, 0.9167f),
                new Vector2 (0f, 0.9583f)
            };

            Vector3[] normals = new Vector3[] {
                new Vector3 (0.00000f, 1.00000f, -0.00000f),
                new Vector3 (-0.00000f, 1.00000f, -0.00000f),
                new Vector3 (0.90365f, 0.42827f, -0.00000f),
                new Vector3 (-0.90365f, 0.42827f, -0.00000f),
                new Vector3 (-1.00000f, 0.00000f, -0.00000f),
                new Vector3 (1.00000f, 0.00000f, -0.00000f)
            };

            MeshData mam = new MeshData()
            {
                Vertices = vertices,
                Triangles = triangles,
                UVs = uv,
                Normals = normals
            };

            return mam;
        }
    }
}