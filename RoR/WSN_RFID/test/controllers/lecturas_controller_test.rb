require 'test_helper'

class LecturasControllerTest < ActionController::TestCase
  setup do
    @lectura = lecturas(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:lecturas)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create lectura" do
    assert_difference('Lectura.count') do
      post :create, lectura: { fecha: @lectura.fecha }
    end

    assert_redirected_to lectura_path(assigns(:lectura))
  end

  test "should show lectura" do
    get :show, id: @lectura
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @lectura
    assert_response :success
  end

  test "should update lectura" do
    patch :update, id: @lectura, lectura: { fecha: @lectura.fecha }
    assert_redirected_to lectura_path(assigns(:lectura))
  end

  test "should destroy lectura" do
    assert_difference('Lectura.count', -1) do
      delete :destroy, id: @lectura
    end

    assert_redirected_to lecturas_path
  end
end
