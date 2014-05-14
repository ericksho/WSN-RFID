require 'test_helper'

class AtributosControllerTest < ActionController::TestCase
  setup do
    @atributo = atributos(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:atributos)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create atributo" do
    assert_difference('Atributo.count') do
      post :create, atributo: { nombre_at: @atributo.nombre_at, tipo_variable: @atributo.tipo_variable, valor: @atributo.valor }
    end

    assert_redirected_to atributo_path(assigns(:atributo))
  end

  test "should show atributo" do
    get :show, id: @atributo
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @atributo
    assert_response :success
  end

  test "should update atributo" do
    patch :update, id: @atributo, atributo: { nombre_at: @atributo.nombre_at, tipo_variable: @atributo.tipo_variable, valor: @atributo.valor }
    assert_redirected_to atributo_path(assigns(:atributo))
  end

  test "should destroy atributo" do
    assert_difference('Atributo.count', -1) do
      delete :destroy, id: @atributo
    end

    assert_redirected_to atributos_path
  end
end
