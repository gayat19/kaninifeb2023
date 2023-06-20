import { configureStore } from "@reduxjs/toolkit";
import internReducer from './InternsSlice';


const store = configureStore({
    reducer:{
       interns:internReducer,
    },
});

export default store;