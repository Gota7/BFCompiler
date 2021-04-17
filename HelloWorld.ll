; ModuleID = 'HelloWorld.bc'
source_filename = "HelloWorld"

declare i32 @putchar(i8)

declare i8 @getchar()

declare i32* @malloc(i32)

declare i32* @memset(i32*, i32, i32)

declare void @free(i32*)

define void @main() {
entry:
  %basePtr = call i32* @malloc(i32 8192)
  %callMemset = call i32* @memset(i32* %basePtr, i32 0, i32 8192)
  %ptr = alloca i8*, align 8
  %tempPtr = bitcast i32* %basePtr to i8*
  store i8* %tempPtr, i8** %ptr, align 8
  %Load_0 = load i8*, i8** %ptr, align 8
  %Load_1 = load i8, i8* %Load_0, align 1
  %Add_2 = add i8 %Load_1, 1
  store i8 %Add_2, i8* %Load_0, align 1
  %Load_3 = load i8*, i8** %ptr, align 8
  %Load_4 = load i8, i8* %Load_3, align 1
  %Add_5 = add i8 %Load_4, 1
  store i8 %Add_5, i8* %Load_3, align 1
  %Load_6 = load i8*, i8** %ptr, align 8
  %Load_7 = load i8, i8* %Load_6, align 1
  %Add_8 = add i8 %Load_7, 1
  store i8 %Add_8, i8* %Load_6, align 1
  %Load_9 = load i8*, i8** %ptr, align 8
  %Load_10 = load i8, i8* %Load_9, align 1
  %Add_11 = add i8 %Load_10, 1
  store i8 %Add_11, i8* %Load_9, align 1
  %Load_12 = load i8*, i8** %ptr, align 8
  %Load_13 = load i8, i8* %Load_12, align 1
  %Add_14 = add i8 %Load_13, 1
  store i8 %Add_14, i8* %Load_12, align 1
  %Load_15 = load i8*, i8** %ptr, align 8
  %Load_16 = load i8, i8* %Load_15, align 1
  %Add_17 = add i8 %Load_16, 1
  store i8 %Add_17, i8* %Load_15, align 1
  %Load_18 = load i8*, i8** %ptr, align 8
  %Load_19 = load i8, i8* %Load_18, align 1
  %Add_20 = add i8 %Load_19, 1
  store i8 %Add_20, i8* %Load_18, align 1
  %Load_21 = load i8*, i8** %ptr, align 8
  %Load_22 = load i8, i8* %Load_21, align 1
  %Add_23 = add i8 %Load_22, 1
  store i8 %Add_23, i8* %Load_21, align 1
  %Load_24 = load i8*, i8** %ptr, align 8
  %Load_25 = load i8, i8* %Load_24, align 1
  %loop_0_compare = icmp ne i8 %Load_25, 0
  br i1 %loop_0_compare, label %loop_0_start, label %loop_0_end

loop_0_start:                                     ; preds = %loop_2_end, %entry
  %Load_26 = load i8*, i8** %ptr, align 8
  %Ptr2Int_27 = ptrtoint i8* %Load_26 to i32
  %Add_28 = add i32 %Ptr2Int_27, 1
  %Int2Ptr_29 = inttoptr i32 %Add_28 to i8*
  store i8* %Int2Ptr_29, i8** %ptr, align 8
  %Load_30 = load i8*, i8** %ptr, align 8
  %Load_31 = load i8, i8* %Load_30, align 1
  %Add_32 = add i8 %Load_31, 1
  store i8 %Add_32, i8* %Load_30, align 1
  %Load_33 = load i8*, i8** %ptr, align 8
  %Load_34 = load i8, i8* %Load_33, align 1
  %Add_35 = add i8 %Load_34, 1
  store i8 %Add_35, i8* %Load_33, align 1
  %Load_36 = load i8*, i8** %ptr, align 8
  %Load_37 = load i8, i8* %Load_36, align 1
  %Add_38 = add i8 %Load_37, 1
  store i8 %Add_38, i8* %Load_36, align 1
  %Load_39 = load i8*, i8** %ptr, align 8
  %Load_40 = load i8, i8* %Load_39, align 1
  %Add_41 = add i8 %Load_40, 1
  store i8 %Add_41, i8* %Load_39, align 1
  %Load_42 = load i8*, i8** %ptr, align 8
  %Load_43 = load i8, i8* %Load_42, align 1
  %loop_1_compare = icmp ne i8 %Load_43, 0
  br i1 %loop_1_compare, label %loop_1_start, label %loop_1_end

loop_0_end:                                       ; preds = %loop_2_end, %entry
  %Load_157 = load i8*, i8** %ptr, align 8
  %Ptr2Int_158 = ptrtoint i8* %Load_157 to i32
  %Add_159 = add i32 %Ptr2Int_158, 1
  %Int2Ptr_160 = inttoptr i32 %Add_159 to i8*
  store i8* %Int2Ptr_160, i8** %ptr, align 8
  %Load_161 = load i8*, i8** %ptr, align 8
  %Ptr2Int_162 = ptrtoint i8* %Load_161 to i32
  %Add_163 = add i32 %Ptr2Int_162, 1
  %Int2Ptr_164 = inttoptr i32 %Add_163 to i8*
  store i8* %Int2Ptr_164, i8** %ptr, align 8
  %Load_165 = load i8*, i8** %ptr, align 8
  %Load_166 = load i8, i8* %Load_165, align 1
  %Output_167 = call i32 @putchar(i8 %Load_166)
  %Load_168 = load i8*, i8** %ptr, align 8
  %Ptr2Int_169 = ptrtoint i8* %Load_168 to i32
  %Add_170 = add i32 %Ptr2Int_169, 1
  %Int2Ptr_171 = inttoptr i32 %Add_170 to i8*
  store i8* %Int2Ptr_171, i8** %ptr, align 8
  %Load_172 = load i8*, i8** %ptr, align 8
  %Load_173 = load i8, i8* %Load_172, align 1
  %Sub_174 = sub i8 %Load_173, 1
  store i8 %Sub_174, i8* %Load_172, align 1
  %Load_175 = load i8*, i8** %ptr, align 8
  %Load_176 = load i8, i8* %Load_175, align 1
  %Sub_177 = sub i8 %Load_176, 1
  store i8 %Sub_177, i8* %Load_175, align 1
  %Load_178 = load i8*, i8** %ptr, align 8
  %Load_179 = load i8, i8* %Load_178, align 1
  %Sub_180 = sub i8 %Load_179, 1
  store i8 %Sub_180, i8* %Load_178, align 1
  %Load_181 = load i8*, i8** %ptr, align 8
  %Load_182 = load i8, i8* %Load_181, align 1
  %Output_183 = call i32 @putchar(i8 %Load_182)
  %Load_184 = load i8*, i8** %ptr, align 8
  %Load_185 = load i8, i8* %Load_184, align 1
  %Add_186 = add i8 %Load_185, 1
  store i8 %Add_186, i8* %Load_184, align 1
  %Load_187 = load i8*, i8** %ptr, align 8
  %Load_188 = load i8, i8* %Load_187, align 1
  %Add_189 = add i8 %Load_188, 1
  store i8 %Add_189, i8* %Load_187, align 1
  %Load_190 = load i8*, i8** %ptr, align 8
  %Load_191 = load i8, i8* %Load_190, align 1
  %Add_192 = add i8 %Load_191, 1
  store i8 %Add_192, i8* %Load_190, align 1
  %Load_193 = load i8*, i8** %ptr, align 8
  %Load_194 = load i8, i8* %Load_193, align 1
  %Add_195 = add i8 %Load_194, 1
  store i8 %Add_195, i8* %Load_193, align 1
  %Load_196 = load i8*, i8** %ptr, align 8
  %Load_197 = load i8, i8* %Load_196, align 1
  %Add_198 = add i8 %Load_197, 1
  store i8 %Add_198, i8* %Load_196, align 1
  %Load_199 = load i8*, i8** %ptr, align 8
  %Load_200 = load i8, i8* %Load_199, align 1
  %Add_201 = add i8 %Load_200, 1
  store i8 %Add_201, i8* %Load_199, align 1
  %Load_202 = load i8*, i8** %ptr, align 8
  %Load_203 = load i8, i8* %Load_202, align 1
  %Add_204 = add i8 %Load_203, 1
  store i8 %Add_204, i8* %Load_202, align 1
  %Load_205 = load i8*, i8** %ptr, align 8
  %Load_206 = load i8, i8* %Load_205, align 1
  %Output_207 = call i32 @putchar(i8 %Load_206)
  %Load_208 = load i8*, i8** %ptr, align 8
  %Load_209 = load i8, i8* %Load_208, align 1
  %Output_210 = call i32 @putchar(i8 %Load_209)
  %Load_211 = load i8*, i8** %ptr, align 8
  %Load_212 = load i8, i8* %Load_211, align 1
  %Add_213 = add i8 %Load_212, 1
  store i8 %Add_213, i8* %Load_211, align 1
  %Load_214 = load i8*, i8** %ptr, align 8
  %Load_215 = load i8, i8* %Load_214, align 1
  %Add_216 = add i8 %Load_215, 1
  store i8 %Add_216, i8* %Load_214, align 1
  %Load_217 = load i8*, i8** %ptr, align 8
  %Load_218 = load i8, i8* %Load_217, align 1
  %Add_219 = add i8 %Load_218, 1
  store i8 %Add_219, i8* %Load_217, align 1
  %Load_220 = load i8*, i8** %ptr, align 8
  %Load_221 = load i8, i8* %Load_220, align 1
  %Output_222 = call i32 @putchar(i8 %Load_221)
  %Load_223 = load i8*, i8** %ptr, align 8
  %Ptr2Int_224 = ptrtoint i8* %Load_223 to i32
  %Add_225 = add i32 %Ptr2Int_224, 1
  %Int2Ptr_226 = inttoptr i32 %Add_225 to i8*
  store i8* %Int2Ptr_226, i8** %ptr, align 8
  %Load_227 = load i8*, i8** %ptr, align 8
  %Ptr2Int_228 = ptrtoint i8* %Load_227 to i32
  %Add_229 = add i32 %Ptr2Int_228, 1
  %Int2Ptr_230 = inttoptr i32 %Add_229 to i8*
  store i8* %Int2Ptr_230, i8** %ptr, align 8
  %Load_231 = load i8*, i8** %ptr, align 8
  %Load_232 = load i8, i8* %Load_231, align 1
  %Output_233 = call i32 @putchar(i8 %Load_232)
  %Load_234 = load i8*, i8** %ptr, align 8
  %Ptr2Int_235 = ptrtoint i8* %Load_234 to i32
  %Sub_236 = sub i32 %Ptr2Int_235, 1
  %Int2Ptr_237 = inttoptr i32 %Sub_236 to i8*
  store i8* %Int2Ptr_237, i8** %ptr, align 8
  %Load_238 = load i8*, i8** %ptr, align 8
  %Load_239 = load i8, i8* %Load_238, align 1
  %Sub_240 = sub i8 %Load_239, 1
  store i8 %Sub_240, i8* %Load_238, align 1
  %Load_241 = load i8*, i8** %ptr, align 8
  %Load_242 = load i8, i8* %Load_241, align 1
  %Output_243 = call i32 @putchar(i8 %Load_242)
  %Load_244 = load i8*, i8** %ptr, align 8
  %Ptr2Int_245 = ptrtoint i8* %Load_244 to i32
  %Sub_246 = sub i32 %Ptr2Int_245, 1
  %Int2Ptr_247 = inttoptr i32 %Sub_246 to i8*
  store i8* %Int2Ptr_247, i8** %ptr, align 8
  %Load_248 = load i8*, i8** %ptr, align 8
  %Load_249 = load i8, i8* %Load_248, align 1
  %Output_250 = call i32 @putchar(i8 %Load_249)
  %Load_251 = load i8*, i8** %ptr, align 8
  %Load_252 = load i8, i8* %Load_251, align 1
  %Add_253 = add i8 %Load_252, 1
  store i8 %Add_253, i8* %Load_251, align 1
  %Load_254 = load i8*, i8** %ptr, align 8
  %Load_255 = load i8, i8* %Load_254, align 1
  %Add_256 = add i8 %Load_255, 1
  store i8 %Add_256, i8* %Load_254, align 1
  %Load_257 = load i8*, i8** %ptr, align 8
  %Load_258 = load i8, i8* %Load_257, align 1
  %Add_259 = add i8 %Load_258, 1
  store i8 %Add_259, i8* %Load_257, align 1
  %Load_260 = load i8*, i8** %ptr, align 8
  %Load_261 = load i8, i8* %Load_260, align 1
  %Output_262 = call i32 @putchar(i8 %Load_261)
  %Load_263 = load i8*, i8** %ptr, align 8
  %Load_264 = load i8, i8* %Load_263, align 1
  %Sub_265 = sub i8 %Load_264, 1
  store i8 %Sub_265, i8* %Load_263, align 1
  %Load_266 = load i8*, i8** %ptr, align 8
  %Load_267 = load i8, i8* %Load_266, align 1
  %Sub_268 = sub i8 %Load_267, 1
  store i8 %Sub_268, i8* %Load_266, align 1
  %Load_269 = load i8*, i8** %ptr, align 8
  %Load_270 = load i8, i8* %Load_269, align 1
  %Sub_271 = sub i8 %Load_270, 1
  store i8 %Sub_271, i8* %Load_269, align 1
  %Load_272 = load i8*, i8** %ptr, align 8
  %Load_273 = load i8, i8* %Load_272, align 1
  %Sub_274 = sub i8 %Load_273, 1
  store i8 %Sub_274, i8* %Load_272, align 1
  %Load_275 = load i8*, i8** %ptr, align 8
  %Load_276 = load i8, i8* %Load_275, align 1
  %Sub_277 = sub i8 %Load_276, 1
  store i8 %Sub_277, i8* %Load_275, align 1
  %Load_278 = load i8*, i8** %ptr, align 8
  %Load_279 = load i8, i8* %Load_278, align 1
  %Sub_280 = sub i8 %Load_279, 1
  store i8 %Sub_280, i8* %Load_278, align 1
  %Load_281 = load i8*, i8** %ptr, align 8
  %Load_282 = load i8, i8* %Load_281, align 1
  %Output_283 = call i32 @putchar(i8 %Load_282)
  %Load_284 = load i8*, i8** %ptr, align 8
  %Load_285 = load i8, i8* %Load_284, align 1
  %Sub_286 = sub i8 %Load_285, 1
  store i8 %Sub_286, i8* %Load_284, align 1
  %Load_287 = load i8*, i8** %ptr, align 8
  %Load_288 = load i8, i8* %Load_287, align 1
  %Sub_289 = sub i8 %Load_288, 1
  store i8 %Sub_289, i8* %Load_287, align 1
  %Load_290 = load i8*, i8** %ptr, align 8
  %Load_291 = load i8, i8* %Load_290, align 1
  %Sub_292 = sub i8 %Load_291, 1
  store i8 %Sub_292, i8* %Load_290, align 1
  %Load_293 = load i8*, i8** %ptr, align 8
  %Load_294 = load i8, i8* %Load_293, align 1
  %Sub_295 = sub i8 %Load_294, 1
  store i8 %Sub_295, i8* %Load_293, align 1
  %Load_296 = load i8*, i8** %ptr, align 8
  %Load_297 = load i8, i8* %Load_296, align 1
  %Sub_298 = sub i8 %Load_297, 1
  store i8 %Sub_298, i8* %Load_296, align 1
  %Load_299 = load i8*, i8** %ptr, align 8
  %Load_300 = load i8, i8* %Load_299, align 1
  %Sub_301 = sub i8 %Load_300, 1
  store i8 %Sub_301, i8* %Load_299, align 1
  %Load_302 = load i8*, i8** %ptr, align 8
  %Load_303 = load i8, i8* %Load_302, align 1
  %Sub_304 = sub i8 %Load_303, 1
  store i8 %Sub_304, i8* %Load_302, align 1
  %Load_305 = load i8*, i8** %ptr, align 8
  %Load_306 = load i8, i8* %Load_305, align 1
  %Sub_307 = sub i8 %Load_306, 1
  store i8 %Sub_307, i8* %Load_305, align 1
  %Load_308 = load i8*, i8** %ptr, align 8
  %Load_309 = load i8, i8* %Load_308, align 1
  %Output_310 = call i32 @putchar(i8 %Load_309)
  %Load_311 = load i8*, i8** %ptr, align 8
  %Ptr2Int_312 = ptrtoint i8* %Load_311 to i32
  %Add_313 = add i32 %Ptr2Int_312, 1
  %Int2Ptr_314 = inttoptr i32 %Add_313 to i8*
  store i8* %Int2Ptr_314, i8** %ptr, align 8
  %Load_315 = load i8*, i8** %ptr, align 8
  %Ptr2Int_316 = ptrtoint i8* %Load_315 to i32
  %Add_317 = add i32 %Ptr2Int_316, 1
  %Int2Ptr_318 = inttoptr i32 %Add_317 to i8*
  store i8* %Int2Ptr_318, i8** %ptr, align 8
  %Load_319 = load i8*, i8** %ptr, align 8
  %Load_320 = load i8, i8* %Load_319, align 1
  %Add_321 = add i8 %Load_320, 1
  store i8 %Add_321, i8* %Load_319, align 1
  %Load_322 = load i8*, i8** %ptr, align 8
  %Load_323 = load i8, i8* %Load_322, align 1
  %Output_324 = call i32 @putchar(i8 %Load_323)
  %Load_325 = load i8*, i8** %ptr, align 8
  %Ptr2Int_326 = ptrtoint i8* %Load_325 to i32
  %Add_327 = add i32 %Ptr2Int_326, 1
  %Int2Ptr_328 = inttoptr i32 %Add_327 to i8*
  store i8* %Int2Ptr_328, i8** %ptr, align 8
  %Load_329 = load i8*, i8** %ptr, align 8
  %Load_330 = load i8, i8* %Load_329, align 1
  %Add_331 = add i8 %Load_330, 1
  store i8 %Add_331, i8* %Load_329, align 1
  %Load_332 = load i8*, i8** %ptr, align 8
  %Load_333 = load i8, i8* %Load_332, align 1
  %Add_334 = add i8 %Load_333, 1
  store i8 %Add_334, i8* %Load_332, align 1
  %Load_335 = load i8*, i8** %ptr, align 8
  %Load_336 = load i8, i8* %Load_335, align 1
  %Output_337 = call i32 @putchar(i8 %Load_336)
  %0 = bitcast i32* %basePtr to i8*
  tail call void bitcast (void (i32*)* @free to void (i8*)*)(i8* %0)
  ret void

loop_1_start:                                     ; preds = %loop_1_start, %loop_0_start
  %Load_44 = load i8*, i8** %ptr, align 8
  %Ptr2Int_45 = ptrtoint i8* %Load_44 to i32
  %Add_46 = add i32 %Ptr2Int_45, 1
  %Int2Ptr_47 = inttoptr i32 %Add_46 to i8*
  store i8* %Int2Ptr_47, i8** %ptr, align 8
  %Load_48 = load i8*, i8** %ptr, align 8
  %Load_49 = load i8, i8* %Load_48, align 1
  %Add_50 = add i8 %Load_49, 1
  store i8 %Add_50, i8* %Load_48, align 1
  %Load_51 = load i8*, i8** %ptr, align 8
  %Load_52 = load i8, i8* %Load_51, align 1
  %Add_53 = add i8 %Load_52, 1
  store i8 %Add_53, i8* %Load_51, align 1
  %Load_54 = load i8*, i8** %ptr, align 8
  %Ptr2Int_55 = ptrtoint i8* %Load_54 to i32
  %Add_56 = add i32 %Ptr2Int_55, 1
  %Int2Ptr_57 = inttoptr i32 %Add_56 to i8*
  store i8* %Int2Ptr_57, i8** %ptr, align 8
  %Load_58 = load i8*, i8** %ptr, align 8
  %Load_59 = load i8, i8* %Load_58, align 1
  %Add_60 = add i8 %Load_59, 1
  store i8 %Add_60, i8* %Load_58, align 1
  %Load_61 = load i8*, i8** %ptr, align 8
  %Load_62 = load i8, i8* %Load_61, align 1
  %Add_63 = add i8 %Load_62, 1
  store i8 %Add_63, i8* %Load_61, align 1
  %Load_64 = load i8*, i8** %ptr, align 8
  %Load_65 = load i8, i8* %Load_64, align 1
  %Add_66 = add i8 %Load_65, 1
  store i8 %Add_66, i8* %Load_64, align 1
  %Load_67 = load i8*, i8** %ptr, align 8
  %Ptr2Int_68 = ptrtoint i8* %Load_67 to i32
  %Add_69 = add i32 %Ptr2Int_68, 1
  %Int2Ptr_70 = inttoptr i32 %Add_69 to i8*
  store i8* %Int2Ptr_70, i8** %ptr, align 8
  %Load_71 = load i8*, i8** %ptr, align 8
  %Load_72 = load i8, i8* %Load_71, align 1
  %Add_73 = add i8 %Load_72, 1
  store i8 %Add_73, i8* %Load_71, align 1
  %Load_74 = load i8*, i8** %ptr, align 8
  %Load_75 = load i8, i8* %Load_74, align 1
  %Add_76 = add i8 %Load_75, 1
  store i8 %Add_76, i8* %Load_74, align 1
  %Load_77 = load i8*, i8** %ptr, align 8
  %Load_78 = load i8, i8* %Load_77, align 1
  %Add_79 = add i8 %Load_78, 1
  store i8 %Add_79, i8* %Load_77, align 1
  %Load_80 = load i8*, i8** %ptr, align 8
  %Ptr2Int_81 = ptrtoint i8* %Load_80 to i32
  %Add_82 = add i32 %Ptr2Int_81, 1
  %Int2Ptr_83 = inttoptr i32 %Add_82 to i8*
  store i8* %Int2Ptr_83, i8** %ptr, align 8
  %Load_84 = load i8*, i8** %ptr, align 8
  %Load_85 = load i8, i8* %Load_84, align 1
  %Add_86 = add i8 %Load_85, 1
  store i8 %Add_86, i8* %Load_84, align 1
  %Load_87 = load i8*, i8** %ptr, align 8
  %Ptr2Int_88 = ptrtoint i8* %Load_87 to i32
  %Sub_89 = sub i32 %Ptr2Int_88, 1
  %Int2Ptr_90 = inttoptr i32 %Sub_89 to i8*
  store i8* %Int2Ptr_90, i8** %ptr, align 8
  %Load_91 = load i8*, i8** %ptr, align 8
  %Ptr2Int_92 = ptrtoint i8* %Load_91 to i32
  %Sub_93 = sub i32 %Ptr2Int_92, 1
  %Int2Ptr_94 = inttoptr i32 %Sub_93 to i8*
  store i8* %Int2Ptr_94, i8** %ptr, align 8
  %Load_95 = load i8*, i8** %ptr, align 8
  %Ptr2Int_96 = ptrtoint i8* %Load_95 to i32
  %Sub_97 = sub i32 %Ptr2Int_96, 1
  %Int2Ptr_98 = inttoptr i32 %Sub_97 to i8*
  store i8* %Int2Ptr_98, i8** %ptr, align 8
  %Load_99 = load i8*, i8** %ptr, align 8
  %Ptr2Int_100 = ptrtoint i8* %Load_99 to i32
  %Sub_101 = sub i32 %Ptr2Int_100, 1
  %Int2Ptr_102 = inttoptr i32 %Sub_101 to i8*
  store i8* %Int2Ptr_102, i8** %ptr, align 8
  %Load_103 = load i8*, i8** %ptr, align 8
  %Load_104 = load i8, i8* %Load_103, align 1
  %Sub_105 = sub i8 %Load_104, 1
  store i8 %Sub_105, i8* %Load_103, align 1
  %Load_106 = load i8*, i8** %ptr, align 8
  %Load_107 = load i8, i8* %Load_106, align 1
  %loop_1_compare2 = icmp ne i8 %Load_107, 0
  br i1 %loop_1_compare2, label %loop_1_start, label %loop_1_end

loop_1_end:                                       ; preds = %loop_1_start, %loop_0_start
  %Load_108 = load i8*, i8** %ptr, align 8
  %Ptr2Int_109 = ptrtoint i8* %Load_108 to i32
  %Add_110 = add i32 %Ptr2Int_109, 1
  %Int2Ptr_111 = inttoptr i32 %Add_110 to i8*
  store i8* %Int2Ptr_111, i8** %ptr, align 8
  %Load_112 = load i8*, i8** %ptr, align 8
  %Load_113 = load i8, i8* %Load_112, align 1
  %Add_114 = add i8 %Load_113, 1
  store i8 %Add_114, i8* %Load_112, align 1
  %Load_115 = load i8*, i8** %ptr, align 8
  %Ptr2Int_116 = ptrtoint i8* %Load_115 to i32
  %Add_117 = add i32 %Ptr2Int_116, 1
  %Int2Ptr_118 = inttoptr i32 %Add_117 to i8*
  store i8* %Int2Ptr_118, i8** %ptr, align 8
  %Load_119 = load i8*, i8** %ptr, align 8
  %Load_120 = load i8, i8* %Load_119, align 1
  %Add_121 = add i8 %Load_120, 1
  store i8 %Add_121, i8* %Load_119, align 1
  %Load_122 = load i8*, i8** %ptr, align 8
  %Ptr2Int_123 = ptrtoint i8* %Load_122 to i32
  %Add_124 = add i32 %Ptr2Int_123, 1
  %Int2Ptr_125 = inttoptr i32 %Add_124 to i8*
  store i8* %Int2Ptr_125, i8** %ptr, align 8
  %Load_126 = load i8*, i8** %ptr, align 8
  %Load_127 = load i8, i8* %Load_126, align 1
  %Sub_128 = sub i8 %Load_127, 1
  store i8 %Sub_128, i8* %Load_126, align 1
  %Load_129 = load i8*, i8** %ptr, align 8
  %Ptr2Int_130 = ptrtoint i8* %Load_129 to i32
  %Add_131 = add i32 %Ptr2Int_130, 1
  %Int2Ptr_132 = inttoptr i32 %Add_131 to i8*
  store i8* %Int2Ptr_132, i8** %ptr, align 8
  %Load_133 = load i8*, i8** %ptr, align 8
  %Ptr2Int_134 = ptrtoint i8* %Load_133 to i32
  %Add_135 = add i32 %Ptr2Int_134, 1
  %Int2Ptr_136 = inttoptr i32 %Add_135 to i8*
  store i8* %Int2Ptr_136, i8** %ptr, align 8
  %Load_137 = load i8*, i8** %ptr, align 8
  %Load_138 = load i8, i8* %Load_137, align 1
  %Add_139 = add i8 %Load_138, 1
  store i8 %Add_139, i8* %Load_137, align 1
  %Load_140 = load i8*, i8** %ptr, align 8
  %Load_141 = load i8, i8* %Load_140, align 1
  %loop_2_compare = icmp ne i8 %Load_141, 0
  br i1 %loop_2_compare, label %loop_2_start, label %loop_2_end

loop_2_start:                                     ; preds = %loop_2_start, %loop_1_end
  %Load_142 = load i8*, i8** %ptr, align 8
  %Ptr2Int_143 = ptrtoint i8* %Load_142 to i32
  %Sub_144 = sub i32 %Ptr2Int_143, 1
  %Int2Ptr_145 = inttoptr i32 %Sub_144 to i8*
  store i8* %Int2Ptr_145, i8** %ptr, align 8
  %Load_146 = load i8*, i8** %ptr, align 8
  %Load_147 = load i8, i8* %Load_146, align 1
  %loop_2_compare2 = icmp ne i8 %Load_147, 0
  br i1 %loop_2_compare2, label %loop_2_start, label %loop_2_end

loop_2_end:                                       ; preds = %loop_2_start, %loop_1_end
  %Load_148 = load i8*, i8** %ptr, align 8
  %Ptr2Int_149 = ptrtoint i8* %Load_148 to i32
  %Sub_150 = sub i32 %Ptr2Int_149, 1
  %Int2Ptr_151 = inttoptr i32 %Sub_150 to i8*
  store i8* %Int2Ptr_151, i8** %ptr, align 8
  %Load_152 = load i8*, i8** %ptr, align 8
  %Load_153 = load i8, i8* %Load_152, align 1
  %Sub_154 = sub i8 %Load_153, 1
  store i8 %Sub_154, i8* %Load_152, align 1
  %Load_155 = load i8*, i8** %ptr, align 8
  %Load_156 = load i8, i8* %Load_155, align 1
  %loop_2_compare21 = icmp ne i8 %Load_156, 0
  br i1 %loop_2_compare21, label %loop_0_start, label %loop_0_end
}
