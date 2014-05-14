require 'test_helper'

class LectorsControllerTest < ActionController::TestCase
  setup do
    @lector = lectors(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:lectors)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create lector" do
    assert_difference('Lector.count') do
      post :create, lector: { posicion: @lector.posicion }
    end

    assert_redirected_to lector_path(assigns(:lector))
  end

  test "should show lector" do
    get :show, id: @lector
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @lector
    assert_response :success
  end

  test "should update lector" do
    patch :update, id: @lector, lector: { posicion: @lector.posicion }
    assert_redirected_to lector_path(assigns(:lector))
  end

  test "should destroy lector" do
    assert_difference('Lector.count', -1) do
      delete :destroy, id: @lector
    end

    assert_redirected_to lectors_path
  end
end
