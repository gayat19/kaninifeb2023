const { createSlice } = require("@reduxjs/toolkit");



const internsSlice = createSlice({
    name:"interns",
    initialState:[{"userId":1,"name":"Ramu","age":22},
    {"userId":2,"name":"Bimu","age":31}],
    reducers:{
        addIntern:(state,action)=>{
            state.push(action.payload);
            // console.log(action.payload);
            // console.log(state);;
        },
         editIntern:(state,action)=>{

            for (let index = 0; index < state.length; index++) {
                if(state[index].userId == action.payload.userId)
                {
                    state[index].name = action.payload.name;
                    state[index].age = action.payload.age;
                }
            }
        },
        deleteInten:(state,action)=>{
            for (let index = 0; index < state.length; index++) {
                if(state[index].userId == action.payload.userId)
                {
                    state.splice(index,1);
                    break;
                }
            }
        },

       
    },
});
//dispacher
export const {addIntern,editIntern,deleteInten} = internsSlice.actions;

//store
export default internsSlice.reducer;

